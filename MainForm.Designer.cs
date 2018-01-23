/*
 * Created by SharpDevelop.
 * User: kai
 * Date: 23.12.2017
 * Time: 01:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace keyout
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		private System.Windows.Forms.TableLayoutPanel MainFormTableLayoutPanel;
		
		private System.Windows.Forms.TableLayoutPanel DirectionTableLayoutPanel;
		private System.Windows.Forms.GroupBox DirectionGroupBox;
		private System.Windows.Forms.Label DirectionTurnLeftLabel;
		private System.Windows.Forms.TextBox DirectionTurnLeftTextBox;
		private System.Windows.Forms.Label DirectionTurnRightLabel;
		private System.Windows.Forms.TextBox DirectionTurnRightTextBox;
		private System.Windows.Forms.Label DirectionPitchUpLabel;
		private System.Windows.Forms.TextBox DirectionPitchUpTextBox;
		private System.Windows.Forms.Label DirectionPitchDownLabel;
		private System.Windows.Forms.TextBox DirectionPitchDownTextBox;
		
		private System.Windows.Forms.TableLayoutPanel MovementTableLayoutPanel;
		private System.Windows.Forms.GroupBox MovementGroupBox;
		private System.Windows.Forms.Label MovementStrafeLeftLabel;
		private System.Windows.Forms.TextBox MovementStrafeLeftTextBox;
		private System.Windows.Forms.Label MovementStrafeRightLabel;
		private System.Windows.Forms.TextBox MovementStrafeRightTextBox;
		private System.Windows.Forms.Label MovementAccelerateLabel;
		private System.Windows.Forms.TextBox MovementAccelerateTextBox;
		private System.Windows.Forms.Label MovementBrakeLabel;
		private System.Windows.Forms.TextBox MovementBrakeTextBox;

		private System.Windows.Forms.TableLayoutPanel ActionTableLayoutPanel;
		private System.Windows.Forms.GroupBox ActionGroupBox;
		private System.Windows.Forms.Label ActionPauseLabel;
		private System.Windows.Forms.TextBox ActionPauseTextBox;
		private System.Windows.Forms.Label ActionTurboLabel;
		private System.Windows.Forms.TextBox ActionTurboTextBox;
		private System.Windows.Forms.Label ActionPowerupLabel;
		private System.Windows.Forms.TextBox ActionPowerupTextBox;
		private System.Windows.Forms.Label ActionsTestLabel;
		private System.Windows.Forms.TextBox ActionTestTextBox;
		
		private System.Windows.Forms.TableLayoutPanel CameraTableLayoutPanel;
		private System.Windows.Forms.GroupBox CameraGroupBox;
		private System.Windows.Forms.Label CameraTurnLeftLabel;
		private System.Windows.Forms.TextBox CameraTurnLeftTextBox;
		private System.Windows.Forms.Label CameraTurnRightLabel;
		private System.Windows.Forms.TextBox CameraTurnRightTextBox;
		private System.Windows.Forms.Label CameraTurnFrontLabel;
		private System.Windows.Forms.TextBox CameraTurnFrontTextBox;
		private System.Windows.Forms.Label CameraTurnBackLabel;
		private System.Windows.Forms.TextBox CameraTurnBackTextBox;
		private System.Windows.Forms.Label CameraLookBackLabel;
		private System.Windows.Forms.TextBox CameraLookBackTextBox;
		private System.Windows.Forms.Label CameraToggleLabel;
		private System.Windows.Forms.TextBox CameraToggleTextBox;
		
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ActionGroupBox = new System.Windows.Forms.GroupBox();
			this.ActionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ActionPauseLabel = new System.Windows.Forms.Label();
			this.ActionPauseTextBox = new System.Windows.Forms.TextBox();
			this.ActionTurboLabel = new System.Windows.Forms.Label();
			this.ActionTurboTextBox = new System.Windows.Forms.TextBox();
			this.ActionPowerupLabel = new System.Windows.Forms.Label();
			this.ActionsTestLabel = new System.Windows.Forms.Label();
			this.ActionPowerupTextBox = new System.Windows.Forms.TextBox();
			this.ActionTestTextBox = new System.Windows.Forms.TextBox();
			this.DirectionGroupBox = new System.Windows.Forms.GroupBox();
			this.DirectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.DirectionTurnLeftLabel = new System.Windows.Forms.Label();
			this.DirectionTurnLeftTextBox = new System.Windows.Forms.TextBox();
			this.DirectionTurnRightLabel = new System.Windows.Forms.Label();
			this.DirectionTurnRightTextBox = new System.Windows.Forms.TextBox();
			this.DirectionPitchUpLabel = new System.Windows.Forms.Label();
			this.DirectionPitchDownLabel = new System.Windows.Forms.Label();
			this.DirectionPitchUpTextBox = new System.Windows.Forms.TextBox();
			this.DirectionPitchDownTextBox = new System.Windows.Forms.TextBox();
			this.MovementGroupBox = new System.Windows.Forms.GroupBox();
			this.MovementTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.MovementStrafeLeftLabel = new System.Windows.Forms.Label();
			this.MovementStrafeLeftTextBox = new System.Windows.Forms.TextBox();
			this.MovementStrafeRightLabel = new System.Windows.Forms.Label();
			this.MovementStrafeRightTextBox = new System.Windows.Forms.TextBox();
			this.MovementAccelerateLabel = new System.Windows.Forms.Label();
			this.MovementBrakeLabel = new System.Windows.Forms.Label();
			this.MovementAccelerateTextBox = new System.Windows.Forms.TextBox();
			this.MovementBrakeTextBox = new System.Windows.Forms.TextBox();
			this.CameraGroupBox = new System.Windows.Forms.GroupBox();
			this.CameraTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.CameraTurnLeftLabel = new System.Windows.Forms.Label();
			this.CameraTurnLeftTextBox = new System.Windows.Forms.TextBox();
			this.CameraTurnRightLabel = new System.Windows.Forms.Label();
			this.CameraTurnRightTextBox = new System.Windows.Forms.TextBox();
			this.CameraTurnFrontLabel = new System.Windows.Forms.Label();
			this.CameraTurnBackLabel = new System.Windows.Forms.Label();
			this.CameraTurnFrontTextBox = new System.Windows.Forms.TextBox();
			this.CameraTurnBackTextBox = new System.Windows.Forms.TextBox();
			this.CameraLookBackLabel = new System.Windows.Forms.Label();
			this.CameraToggleLabel = new System.Windows.Forms.Label();
			this.CameraLookBackTextBox = new System.Windows.Forms.TextBox();
			this.CameraToggleTextBox = new System.Windows.Forms.TextBox();
			this.MainFormTableLayoutPanel.SuspendLayout();
			this.ActionGroupBox.SuspendLayout();
			this.ActionTableLayoutPanel.SuspendLayout();
			this.DirectionGroupBox.SuspendLayout();
			this.DirectionTableLayoutPanel.SuspendLayout();
			this.MovementGroupBox.SuspendLayout();
			this.MovementTableLayoutPanel.SuspendLayout();
			this.CameraGroupBox.SuspendLayout();
			this.CameraTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainFormTableLayoutPanel
			// 
			this.MainFormTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MainFormTableLayoutPanel.ColumnCount = 2;
			this.MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MainFormTableLayoutPanel.Controls.Add(this.ActionGroupBox, 0, 1);
			this.MainFormTableLayoutPanel.Controls.Add(this.DirectionGroupBox, 0, 0);
			this.MainFormTableLayoutPanel.Controls.Add(this.MovementGroupBox, 1, 0);
			this.MainFormTableLayoutPanel.Controls.Add(this.CameraGroupBox, 1, 1);
			this.MainFormTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.MainFormTableLayoutPanel.Name = "MainFormTableLayoutPanel";
			this.MainFormTableLayoutPanel.RowCount = 2;
			this.MainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.MainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.MainFormTableLayoutPanel.Size = new System.Drawing.Size(494, 305);
			this.MainFormTableLayoutPanel.TabIndex = 0;
			// 
			// ActionGroupBox
			// 
			this.ActionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionGroupBox.Controls.Add(this.ActionTableLayoutPanel);
			this.ActionGroupBox.Location = new System.Drawing.Point(3, 125);
			this.ActionGroupBox.Name = "ActionGroupBox";
			this.ActionGroupBox.Size = new System.Drawing.Size(241, 177);
			this.ActionGroupBox.TabIndex = 4;
			this.ActionGroupBox.TabStop = false;
			this.ActionGroupBox.Text = "Actions";
			// 
			// ActionTableLayoutPanel
			// 
			this.ActionTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionTableLayoutPanel.ColumnCount = 2;
			this.ActionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83498F));
			this.ActionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16502F));
			this.ActionTableLayoutPanel.Controls.Add(this.ActionPauseLabel, 0, 0);
			this.ActionTableLayoutPanel.Controls.Add(this.ActionPauseTextBox, 1, 0);
			this.ActionTableLayoutPanel.Controls.Add(this.ActionTurboLabel, 0, 1);
			this.ActionTableLayoutPanel.Controls.Add(this.ActionTurboTextBox, 1, 1);
			this.ActionTableLayoutPanel.Controls.Add(this.ActionPowerupLabel, 0, 2);
			this.ActionTableLayoutPanel.Controls.Add(this.ActionsTestLabel, 0, 3);
			this.ActionTableLayoutPanel.Controls.Add(this.ActionPowerupTextBox, 1, 2);
			this.ActionTableLayoutPanel.Controls.Add(this.ActionTestTextBox, 1, 3);
			this.ActionTableLayoutPanel.Location = new System.Drawing.Point(7, 13);
			this.ActionTableLayoutPanel.Name = "ActionTableLayoutPanel";
			this.ActionTableLayoutPanel.RowCount = 6;
			this.ActionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.ActionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.ActionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.ActionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.ActionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.ActionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.ActionTableLayoutPanel.Size = new System.Drawing.Size(228, 158);
			this.ActionTableLayoutPanel.TabIndex = 1;
			// 
			// ActionPauseLabel
			// 
			this.ActionPauseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionPauseLabel.Location = new System.Drawing.Point(3, 0);
			this.ActionPauseLabel.Name = "ActionPauseLabel";
			this.ActionPauseLabel.Size = new System.Drawing.Size(107, 23);
			this.ActionPauseLabel.TabIndex = 0;
			this.ActionPauseLabel.Text = "Pause";
			this.ActionPauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ActionPauseTextBox
			// 
			this.ActionPauseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionPauseTextBox.Location = new System.Drawing.Point(116, 3);
			this.ActionPauseTextBox.Name = "ActionPauseTextBox";
			this.ActionPauseTextBox.ReadOnly = true;
			this.ActionPauseTextBox.Size = new System.Drawing.Size(109, 20);
			this.ActionPauseTextBox.TabIndex = 1;
			this.ActionPauseTextBox.Text = "-";
			this.ActionPauseTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.ActionPauseTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.ActionPauseTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// ActionTurboLabel
			// 
			this.ActionTurboLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionTurboLabel.Location = new System.Drawing.Point(3, 26);
			this.ActionTurboLabel.Name = "ActionTurboLabel";
			this.ActionTurboLabel.Size = new System.Drawing.Size(107, 23);
			this.ActionTurboLabel.TabIndex = 3;
			this.ActionTurboLabel.Text = "Turbo";
			this.ActionTurboLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ActionTurboTextBox
			// 
			this.ActionTurboTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionTurboTextBox.Location = new System.Drawing.Point(116, 29);
			this.ActionTurboTextBox.Name = "ActionTurboTextBox";
			this.ActionTurboTextBox.ReadOnly = true;
			this.ActionTurboTextBox.Size = new System.Drawing.Size(109, 20);
			this.ActionTurboTextBox.TabIndex = 1;
			this.ActionTurboTextBox.Text = "-";
			this.ActionTurboTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.ActionTurboTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.ActionTurboTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// ActionPowerupLabel
			// 
			this.ActionPowerupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionPowerupLabel.Location = new System.Drawing.Point(3, 52);
			this.ActionPowerupLabel.Name = "ActionPowerupLabel";
			this.ActionPowerupLabel.Size = new System.Drawing.Size(107, 23);
			this.ActionPowerupLabel.TabIndex = 2;
			this.ActionPowerupLabel.Text = "Powerup";
			this.ActionPowerupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ActionsTestLabel
			// 
			this.ActionsTestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionsTestLabel.Location = new System.Drawing.Point(3, 78);
			this.ActionsTestLabel.Name = "ActionsTestLabel";
			this.ActionsTestLabel.Size = new System.Drawing.Size(107, 23);
			this.ActionsTestLabel.TabIndex = 0;
			this.ActionsTestLabel.Text = "(Test area)";
			this.ActionsTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ActionPowerupTextBox
			// 
			this.ActionPowerupTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionPowerupTextBox.Location = new System.Drawing.Point(116, 55);
			this.ActionPowerupTextBox.Name = "ActionPowerupTextBox";
			this.ActionPowerupTextBox.ReadOnly = true;
			this.ActionPowerupTextBox.Size = new System.Drawing.Size(109, 20);
			this.ActionPowerupTextBox.TabIndex = 4;
			this.ActionPowerupTextBox.Text = "-";
			this.ActionPowerupTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.ActionPowerupTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.ActionPowerupTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// ActionTestTextBox
			// 
			this.ActionTestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ActionTestTextBox.Location = new System.Drawing.Point(116, 81);
			this.ActionTestTextBox.Name = "ActionTestTextBox";
			this.ActionTestTextBox.Size = new System.Drawing.Size(109, 20);
			this.ActionTestTextBox.TabIndex = 5;
			this.ActionTestTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.ActionTestTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.ActionTestTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// DirectionGroupBox
			// 
			this.DirectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionGroupBox.Controls.Add(this.DirectionTableLayoutPanel);
			this.DirectionGroupBox.Location = new System.Drawing.Point(3, 3);
			this.DirectionGroupBox.Name = "DirectionGroupBox";
			this.DirectionGroupBox.Size = new System.Drawing.Size(241, 116);
			this.DirectionGroupBox.TabIndex = 0;
			this.DirectionGroupBox.TabStop = false;
			this.DirectionGroupBox.Text = "Direction";
			// 
			// DirectionTableLayoutPanel
			// 
			this.DirectionTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionTableLayoutPanel.ColumnCount = 2;
			this.DirectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83498F));
			this.DirectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16502F));
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionTurnLeftLabel, 0, 0);
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionTurnLeftTextBox, 1, 0);
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionTurnRightLabel, 0, 1);
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionTurnRightTextBox, 1, 1);
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionPitchUpLabel, 0, 2);
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionPitchDownLabel, 0, 3);
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionPitchUpTextBox, 1, 2);
			this.DirectionTableLayoutPanel.Controls.Add(this.DirectionPitchDownTextBox, 1, 3);
			this.DirectionTableLayoutPanel.Location = new System.Drawing.Point(7, 20);
			this.DirectionTableLayoutPanel.Name = "DirectionTableLayoutPanel";
			this.DirectionTableLayoutPanel.RowCount = 4;
			this.DirectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.DirectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.DirectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.DirectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.DirectionTableLayoutPanel.Size = new System.Drawing.Size(228, 90);
			this.DirectionTableLayoutPanel.TabIndex = 0;
			// 
			// DirectionTurnLeftLabel
			// 
			this.DirectionTurnLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionTurnLeftLabel.Location = new System.Drawing.Point(3, 0);
			this.DirectionTurnLeftLabel.Name = "DirectionTurnLeftLabel";
			this.DirectionTurnLeftLabel.Size = new System.Drawing.Size(107, 22);
			this.DirectionTurnLeftLabel.TabIndex = 0;
			this.DirectionTurnLeftLabel.Text = "Turn left ←";
			this.DirectionTurnLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DirectionTurnLeftTextBox
			// 
			this.DirectionTurnLeftTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionTurnLeftTextBox.Location = new System.Drawing.Point(116, 3);
			this.DirectionTurnLeftTextBox.Name = "DirectionTurnLeftTextBox";
			this.DirectionTurnLeftTextBox.ReadOnly = true;
			this.DirectionTurnLeftTextBox.Size = new System.Drawing.Size(109, 20);
			this.DirectionTurnLeftTextBox.TabIndex = 1;
			this.DirectionTurnLeftTextBox.Text = "-";
			this.DirectionTurnLeftTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.DirectionTurnLeftTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.DirectionTurnLeftTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// DirectionTurnRightLabel
			// 
			this.DirectionTurnRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionTurnRightLabel.Location = new System.Drawing.Point(3, 22);
			this.DirectionTurnRightLabel.Name = "DirectionTurnRightLabel";
			this.DirectionTurnRightLabel.Size = new System.Drawing.Size(107, 22);
			this.DirectionTurnRightLabel.TabIndex = 0;
			this.DirectionTurnRightLabel.Text = "Turn right →";
			this.DirectionTurnRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DirectionTurnRightTextBox
			// 
			this.DirectionTurnRightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionTurnRightTextBox.Location = new System.Drawing.Point(116, 25);
			this.DirectionTurnRightTextBox.Name = "DirectionTurnRightTextBox";
			this.DirectionTurnRightTextBox.ReadOnly = true;
			this.DirectionTurnRightTextBox.Size = new System.Drawing.Size(109, 20);
			this.DirectionTurnRightTextBox.TabIndex = 1;
			this.DirectionTurnRightTextBox.Text = "-";
			this.DirectionTurnRightTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.DirectionTurnRightTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.DirectionTurnRightTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// DirectionPitchUpLabel
			// 
			this.DirectionPitchUpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionPitchUpLabel.Location = new System.Drawing.Point(3, 44);
			this.DirectionPitchUpLabel.Name = "DirectionPitchUpLabel";
			this.DirectionPitchUpLabel.Size = new System.Drawing.Size(107, 22);
			this.DirectionPitchUpLabel.TabIndex = 2;
			this.DirectionPitchUpLabel.Text = "Pitch up ↑";
			this.DirectionPitchUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DirectionPitchDownLabel
			// 
			this.DirectionPitchDownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionPitchDownLabel.Location = new System.Drawing.Point(3, 66);
			this.DirectionPitchDownLabel.Name = "DirectionPitchDownLabel";
			this.DirectionPitchDownLabel.Size = new System.Drawing.Size(107, 23);
			this.DirectionPitchDownLabel.TabIndex = 3;
			this.DirectionPitchDownLabel.Text = "Pitch down ↓";
			this.DirectionPitchDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DirectionPitchUpTextBox
			// 
			this.DirectionPitchUpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionPitchUpTextBox.Location = new System.Drawing.Point(116, 47);
			this.DirectionPitchUpTextBox.Name = "DirectionPitchUpTextBox";
			this.DirectionPitchUpTextBox.ReadOnly = true;
			this.DirectionPitchUpTextBox.Size = new System.Drawing.Size(109, 20);
			this.DirectionPitchUpTextBox.TabIndex = 4;
			this.DirectionPitchUpTextBox.Text = "-";
			this.DirectionPitchUpTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.DirectionPitchUpTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.DirectionPitchUpTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// DirectionPitchDownTextBox
			// 
			this.DirectionPitchDownTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DirectionPitchDownTextBox.Location = new System.Drawing.Point(116, 69);
			this.DirectionPitchDownTextBox.Name = "DirectionPitchDownTextBox";
			this.DirectionPitchDownTextBox.ReadOnly = true;
			this.DirectionPitchDownTextBox.Size = new System.Drawing.Size(109, 20);
			this.DirectionPitchDownTextBox.TabIndex = 5;
			this.DirectionPitchDownTextBox.Text = "-";
			this.DirectionPitchDownTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.DirectionPitchDownTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.DirectionPitchDownTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// MovementGroupBox
			// 
			this.MovementGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementGroupBox.Controls.Add(this.MovementTableLayoutPanel);
			this.MovementGroupBox.Location = new System.Drawing.Point(250, 3);
			this.MovementGroupBox.Name = "MovementGroupBox";
			this.MovementGroupBox.Size = new System.Drawing.Size(241, 116);
			this.MovementGroupBox.TabIndex = 1;
			this.MovementGroupBox.TabStop = false;
			this.MovementGroupBox.Text = "Movement";
			// 
			// MovementTableLayoutPanel
			// 
			this.MovementTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementTableLayoutPanel.ColumnCount = 2;
			this.MovementTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83498F));
			this.MovementTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16502F));
			this.MovementTableLayoutPanel.Controls.Add(this.MovementStrafeLeftLabel, 0, 0);
			this.MovementTableLayoutPanel.Controls.Add(this.MovementStrafeLeftTextBox, 1, 0);
			this.MovementTableLayoutPanel.Controls.Add(this.MovementStrafeRightLabel, 0, 1);
			this.MovementTableLayoutPanel.Controls.Add(this.MovementStrafeRightTextBox, 1, 1);
			this.MovementTableLayoutPanel.Controls.Add(this.MovementAccelerateLabel, 0, 2);
			this.MovementTableLayoutPanel.Controls.Add(this.MovementBrakeLabel, 0, 3);
			this.MovementTableLayoutPanel.Controls.Add(this.MovementAccelerateTextBox, 1, 2);
			this.MovementTableLayoutPanel.Controls.Add(this.MovementBrakeTextBox, 1, 3);
			this.MovementTableLayoutPanel.Location = new System.Drawing.Point(7, 13);
			this.MovementTableLayoutPanel.Name = "MovementTableLayoutPanel";
			this.MovementTableLayoutPanel.RowCount = 4;
			this.MovementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.MovementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.MovementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.MovementTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.MovementTableLayoutPanel.Size = new System.Drawing.Size(228, 97);
			this.MovementTableLayoutPanel.TabIndex = 1;
			// 
			// MovementStrafeLeftLabel
			// 
			this.MovementStrafeLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementStrafeLeftLabel.Location = new System.Drawing.Point(3, 0);
			this.MovementStrafeLeftLabel.Name = "MovementStrafeLeftLabel";
			this.MovementStrafeLeftLabel.Size = new System.Drawing.Size(107, 23);
			this.MovementStrafeLeftLabel.TabIndex = 0;
			this.MovementStrafeLeftLabel.Text = "Strafe left ←";
			this.MovementStrafeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MovementStrafeLeftTextBox
			// 
			this.MovementStrafeLeftTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementStrafeLeftTextBox.Location = new System.Drawing.Point(116, 3);
			this.MovementStrafeLeftTextBox.Name = "MovementStrafeLeftTextBox";
			this.MovementStrafeLeftTextBox.ReadOnly = true;
			this.MovementStrafeLeftTextBox.Size = new System.Drawing.Size(109, 20);
			this.MovementStrafeLeftTextBox.TabIndex = 1;
			this.MovementStrafeLeftTextBox.Text = "-";
			this.MovementStrafeLeftTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.MovementStrafeLeftTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.MovementStrafeLeftTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// MovementStrafeRightLabel
			// 
			this.MovementStrafeRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementStrafeRightLabel.Location = new System.Drawing.Point(3, 24);
			this.MovementStrafeRightLabel.Name = "MovementStrafeRightLabel";
			this.MovementStrafeRightLabel.Size = new System.Drawing.Size(107, 23);
			this.MovementStrafeRightLabel.TabIndex = 0;
			this.MovementStrafeRightLabel.Text = "Strafe right →";
			this.MovementStrafeRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MovementStrafeRightTextBox
			// 
			this.MovementStrafeRightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementStrafeRightTextBox.Location = new System.Drawing.Point(116, 27);
			this.MovementStrafeRightTextBox.Name = "MovementStrafeRightTextBox";
			this.MovementStrafeRightTextBox.ReadOnly = true;
			this.MovementStrafeRightTextBox.Size = new System.Drawing.Size(109, 20);
			this.MovementStrafeRightTextBox.TabIndex = 1;
			this.MovementStrafeRightTextBox.Text = "-";
			this.MovementStrafeRightTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.MovementStrafeRightTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.MovementStrafeRightTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// MovementAccelerateLabel
			// 
			this.MovementAccelerateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementAccelerateLabel.Location = new System.Drawing.Point(3, 48);
			this.MovementAccelerateLabel.Name = "MovementAccelerateLabel";
			this.MovementAccelerateLabel.Size = new System.Drawing.Size(107, 23);
			this.MovementAccelerateLabel.TabIndex = 2;
			this.MovementAccelerateLabel.Text = "Accelerate ↑";
			this.MovementAccelerateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MovementBrakeLabel
			// 
			this.MovementBrakeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementBrakeLabel.Location = new System.Drawing.Point(3, 72);
			this.MovementBrakeLabel.Name = "MovementBrakeLabel";
			this.MovementBrakeLabel.Size = new System.Drawing.Size(107, 23);
			this.MovementBrakeLabel.TabIndex = 3;
			this.MovementBrakeLabel.Text = "Brake/Reverse ↓";
			this.MovementBrakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MovementAccelerateTextBox
			// 
			this.MovementAccelerateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementAccelerateTextBox.Location = new System.Drawing.Point(116, 51);
			this.MovementAccelerateTextBox.Name = "MovementAccelerateTextBox";
			this.MovementAccelerateTextBox.ReadOnly = true;
			this.MovementAccelerateTextBox.Size = new System.Drawing.Size(109, 20);
			this.MovementAccelerateTextBox.TabIndex = 4;
			this.MovementAccelerateTextBox.Text = "-";
			this.MovementAccelerateTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.MovementAccelerateTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.MovementAccelerateTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// MovementBrakeTextBox
			// 
			this.MovementBrakeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.MovementBrakeTextBox.Location = new System.Drawing.Point(116, 75);
			this.MovementBrakeTextBox.Name = "MovementBrakeTextBox";
			this.MovementBrakeTextBox.ReadOnly = true;
			this.MovementBrakeTextBox.Size = new System.Drawing.Size(109, 20);
			this.MovementBrakeTextBox.TabIndex = 5;
			this.MovementBrakeTextBox.Text = "-";
			this.MovementBrakeTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.MovementBrakeTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.MovementBrakeTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// CameraGroupBox
			// 
			this.CameraGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraGroupBox.Controls.Add(this.CameraTableLayoutPanel);
			this.CameraGroupBox.Location = new System.Drawing.Point(250, 125);
			this.CameraGroupBox.Name = "CameraGroupBox";
			this.CameraGroupBox.Size = new System.Drawing.Size(241, 177);
			this.CameraGroupBox.TabIndex = 3;
			this.CameraGroupBox.TabStop = false;
			this.CameraGroupBox.Text = "Camera";
			// 
			// CameraTableLayoutPanel
			// 
			this.CameraTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTableLayoutPanel.ColumnCount = 2;
			this.CameraTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83498F));
			this.CameraTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16502F));
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnLeftLabel, 0, 0);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnLeftTextBox, 1, 0);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnRightLabel, 0, 1);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnRightTextBox, 1, 1);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnFrontLabel, 0, 2);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnBackLabel, 0, 3);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnFrontTextBox, 1, 2);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraTurnBackTextBox, 1, 3);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraLookBackLabel, 0, 4);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraToggleLabel, 0, 5);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraLookBackTextBox, 1, 4);
			this.CameraTableLayoutPanel.Controls.Add(this.CameraToggleTextBox, 1, 5);
			this.CameraTableLayoutPanel.Location = new System.Drawing.Point(8, 13);
			this.CameraTableLayoutPanel.Name = "CameraTableLayoutPanel";
			this.CameraTableLayoutPanel.RowCount = 6;
			this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.CameraTableLayoutPanel.Size = new System.Drawing.Size(226, 158);
			this.CameraTableLayoutPanel.TabIndex = 1;
			// 
			// CameraTurnLeftLabel
			// 
			this.CameraTurnLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnLeftLabel.Location = new System.Drawing.Point(3, 0);
			this.CameraTurnLeftLabel.Name = "CameraTurnLeftLabel";
			this.CameraTurnLeftLabel.Size = new System.Drawing.Size(106, 23);
			this.CameraTurnLeftLabel.TabIndex = 0;
			this.CameraTurnLeftLabel.Text = "Turn left ←";
			this.CameraTurnLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CameraTurnLeftTextBox
			// 
			this.CameraTurnLeftTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnLeftTextBox.Location = new System.Drawing.Point(115, 3);
			this.CameraTurnLeftTextBox.Name = "CameraTurnLeftTextBox";
			this.CameraTurnLeftTextBox.ReadOnly = true;
			this.CameraTurnLeftTextBox.Size = new System.Drawing.Size(108, 20);
			this.CameraTurnLeftTextBox.TabIndex = 1;
			this.CameraTurnLeftTextBox.Text = "-";
			this.CameraTurnLeftTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.CameraTurnLeftTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.CameraTurnLeftTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// CameraTurnRightLabel
			// 
			this.CameraTurnRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnRightLabel.Location = new System.Drawing.Point(3, 26);
			this.CameraTurnRightLabel.Name = "CameraTurnRightLabel";
			this.CameraTurnRightLabel.Size = new System.Drawing.Size(106, 23);
			this.CameraTurnRightLabel.TabIndex = 0;
			this.CameraTurnRightLabel.Text = "Turn right →";
			this.CameraTurnRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CameraTurnRightTextBox
			// 
			this.CameraTurnRightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnRightTextBox.Location = new System.Drawing.Point(115, 29);
			this.CameraTurnRightTextBox.Name = "CameraTurnRightTextBox";
			this.CameraTurnRightTextBox.ReadOnly = true;
			this.CameraTurnRightTextBox.Size = new System.Drawing.Size(108, 20);
			this.CameraTurnRightTextBox.TabIndex = 1;
			this.CameraTurnRightTextBox.Text = "-";
			this.CameraTurnRightTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.CameraTurnRightTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.CameraTurnRightTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// CameraTurnFrontLabel
			// 
			this.CameraTurnFrontLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnFrontLabel.Location = new System.Drawing.Point(3, 52);
			this.CameraTurnFrontLabel.Name = "CameraTurnFrontLabel";
			this.CameraTurnFrontLabel.Size = new System.Drawing.Size(106, 23);
			this.CameraTurnFrontLabel.TabIndex = 2;
			this.CameraTurnFrontLabel.Text = "Turn front ↑";
			this.CameraTurnFrontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CameraTurnBackLabel
			// 
			this.CameraTurnBackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnBackLabel.Location = new System.Drawing.Point(3, 78);
			this.CameraTurnBackLabel.Name = "CameraTurnBackLabel";
			this.CameraTurnBackLabel.Size = new System.Drawing.Size(106, 23);
			this.CameraTurnBackLabel.TabIndex = 3;
			this.CameraTurnBackLabel.Text = "Turn back ↓";
			this.CameraTurnBackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CameraTurnFrontTextBox
			// 
			this.CameraTurnFrontTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnFrontTextBox.Location = new System.Drawing.Point(115, 55);
			this.CameraTurnFrontTextBox.Name = "CameraTurnFrontTextBox";
			this.CameraTurnFrontTextBox.ReadOnly = true;
			this.CameraTurnFrontTextBox.Size = new System.Drawing.Size(108, 20);
			this.CameraTurnFrontTextBox.TabIndex = 4;
			this.CameraTurnFrontTextBox.Text = "-";
			this.CameraTurnFrontTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.CameraTurnFrontTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.CameraTurnFrontTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// CameraTurnBackTextBox
			// 
			this.CameraTurnBackTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraTurnBackTextBox.Location = new System.Drawing.Point(115, 81);
			this.CameraTurnBackTextBox.Name = "CameraTurnBackTextBox";
			this.CameraTurnBackTextBox.ReadOnly = true;
			this.CameraTurnBackTextBox.Size = new System.Drawing.Size(108, 20);
			this.CameraTurnBackTextBox.TabIndex = 5;
			this.CameraTurnBackTextBox.Text = "-";
			this.CameraTurnBackTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.CameraTurnBackTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.CameraTurnBackTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// CameraLookBackLabel
			// 
			this.CameraLookBackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraLookBackLabel.Location = new System.Drawing.Point(3, 104);
			this.CameraLookBackLabel.Name = "CameraLookBackLabel";
			this.CameraLookBackLabel.Size = new System.Drawing.Size(106, 23);
			this.CameraLookBackLabel.TabIndex = 6;
			this.CameraLookBackLabel.Text = "Look back";
			this.CameraLookBackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CameraToggleLabel
			// 
			this.CameraToggleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraToggleLabel.Location = new System.Drawing.Point(3, 130);
			this.CameraToggleLabel.Name = "CameraToggleLabel";
			this.CameraToggleLabel.Size = new System.Drawing.Size(106, 23);
			this.CameraToggleLabel.TabIndex = 7;
			this.CameraToggleLabel.Text = "Change perspective";
			this.CameraToggleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CameraLookBackTextBox
			// 
			this.CameraLookBackTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraLookBackTextBox.Location = new System.Drawing.Point(115, 107);
			this.CameraLookBackTextBox.Name = "CameraLookBackTextBox";
			this.CameraLookBackTextBox.ReadOnly = true;
			this.CameraLookBackTextBox.Size = new System.Drawing.Size(108, 20);
			this.CameraLookBackTextBox.TabIndex = 8;
			this.CameraLookBackTextBox.Text = "-";
			this.CameraLookBackTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.CameraLookBackTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.CameraLookBackTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// CameraToggleTextBox
			// 
			this.CameraToggleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.CameraToggleTextBox.Location = new System.Drawing.Point(115, 133);
			this.CameraToggleTextBox.Name = "CameraToggleTextBox";
			this.CameraToggleTextBox.ReadOnly = true;
			this.CameraToggleTextBox.Size = new System.Drawing.Size(108, 20);
			this.CameraToggleTextBox.TabIndex = 9;
			this.CameraToggleTextBox.Text = "-";
			this.CameraToggleTextBox.Enter += new System.EventHandler(this.OnKeybindingFocusEnter);
			this.CameraToggleTextBox.Leave += new System.EventHandler(this.OnKeybindingFocusLeave);
			this.CameraToggleTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnKeybindingMouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 329);
			this.Controls.Add(this.MainFormTableLayoutPanel);
			this.Name = "MainForm";
			this.Text = "[k]eyout";
			this.MainFormTableLayoutPanel.ResumeLayout(false);
			this.ActionGroupBox.ResumeLayout(false);
			this.ActionTableLayoutPanel.ResumeLayout(false);
			this.ActionTableLayoutPanel.PerformLayout();
			this.DirectionGroupBox.ResumeLayout(false);
			this.DirectionTableLayoutPanel.ResumeLayout(false);
			this.DirectionTableLayoutPanel.PerformLayout();
			this.MovementGroupBox.ResumeLayout(false);
			this.MovementTableLayoutPanel.ResumeLayout(false);
			this.MovementTableLayoutPanel.PerformLayout();
			this.CameraGroupBox.ResumeLayout(false);
			this.CameraTableLayoutPanel.ResumeLayout(false);
			this.CameraTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
