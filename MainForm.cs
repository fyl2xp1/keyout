using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace keyout
{
	public partial class MainForm : Form
	{
		private TextBox currentTextBox = null;
		
		private readonly KeyConfiguration keyConfiguration;
		private readonly List<TextBox> textBoxes = new List<TextBox>();

		public MainForm(KeyConfiguration keyConfiguration)
		{
			this.keyConfiguration = keyConfiguration;
			InitializeComponent();
			
			tagTextBox(DirectionTurnLeftTextBox, Actions.TurnLeft);
			tagTextBox(DirectionTurnRightTextBox, Actions.TurnRight);
			tagTextBox(DirectionPitchUpTextBox, Actions.PitchUp);
			tagTextBox(DirectionPitchDownTextBox, Actions.PitchDown);
			
			tagTextBox(MovementStrafeLeftTextBox, Actions.RollLeft);
			tagTextBox(MovementStrafeRightTextBox, Actions.RollRight);
			tagTextBox(MovementAccelerateTextBox, Actions.Acceleration);
			tagTextBox(MovementBrakeTextBox, Actions.Brake);

			tagTextBox(ActionPauseTextBox, Actions.Pause);
			tagTextBox(ActionTurboTextBox, Actions.Turbo);
			tagTextBox(ActionPowerupTextBox, Actions.PowerUp);
			tagTextBox(ActionTestTextBox, Actions.None);

			tagTextBox(CameraTurnLeftTextBox, Actions.MoveCameraLeft);
			tagTextBox(CameraTurnRightTextBox, Actions.MoveCameraRight);
			tagTextBox(CameraTurnFrontTextBox, Actions.MoveCameraFront);
			tagTextBox(CameraTurnBackTextBox, Actions.MoveCameraBack);
			tagTextBox(CameraLookBackTextBox, Actions.LookBack);
			tagTextBox(CameraToggleTextBox, Actions.ToggleCamera);
			
			updateTextBoxes();
			this.ActiveControl = ActionTestTextBox;
		}
		
		private void tagTextBox(TextBox textBox, Actions action)
		{
			textBox.Tag = action;
			textBoxes.Add(textBox);
		}
		
		public bool HandleKeyEvent(int eventType, Extern.KBDLLHOOKSTRUCT kbd)
		{
			if (!ContainsFocus)
				return false;
			
			if (currentTextBox == null)
				return false;

			if (eventType != Extern.WM_KEYDOWN && eventType != Extern.WM_SYSKEYDOWN)
				return false;
			
			var key = (Keys)kbd.vkCode;
			if (key == Keys.Scroll)
				return false;

			var action = (Actions)currentTextBox.Tag;
			if (action == Actions.None)
				return false;

			bool isExtended = kbd.flags.HasFlag(Extern.KBDLLHOOKSTRUCTFlags.LLKHF_EXTENDED);
			Debug.WriteLine("vkCode: " + key + "(" + kbd.vkCode + "); scanCode: " + kbd.scanCode + "; flags: " + kbd.flags);
			keyConfiguration.Assign(action, key, (byte)(kbd.scanCode & 0xff), isExtended);
			
			updateTextBoxes();
			ActionTestTextBox.Focus();
			return true;
		}
		
		private void updateTextBoxes()
		{
			foreach (var textBox in textBoxes) {
				var action = (Actions)textBox.Tag;
				if (action == Actions.None)
					continue;
				var actionKey = keyConfiguration.GetActionKey(action);
				textBox.Text = (actionKey.isExtended ? "*" : "") + actionKey.scanCode + " (" + actionKey.key + ")";
			}
		}
		
		void OnKeybindingFocusEnter(object sender, System.EventArgs e)
		{
			var textBox = sender as TextBox;
			if (textBox == null)
				return;
			
			var tempColor = textBox.BackColor;
			textBox.BackColor = textBox.ForeColor;
			textBox.ForeColor = tempColor;
			currentTextBox = textBox;
			
			Debug.WriteLine(sender);
		}
		
		void OnKeybindingFocusLeave(object sender, System.EventArgs e)
		{
			var textBox = sender as TextBox;
			if (textBox == null)
				return;
			
			var tempColor = textBox.BackColor;
			textBox.BackColor = textBox.ForeColor;
			textBox.ForeColor = tempColor;
			currentTextBox = null;
		}
		
		void OnKeybindingMouseDoubleClick(object sender, System.EventArgs e)
		{
			var textBox = sender as TextBox;
			if (textBox == null)
				return;
			
			var action = (Actions)textBox.Tag;
			if (action == Actions.None)
				return;
			
			keyConfiguration.Reset(action);
			updateTextBoxes();
		}
		
	}
	
}
