using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace keyout
{
	internal sealed class Program
	{
		// Temporarily used for my hardcoded key assignments
		private const uint QWERTY_SCANCODE_NUMPAD0 = 82;

		private static readonly KeyConfiguration keyConfiguration = new KeyConfiguration(KeyConfiguration.REDOUT);
		private static MainForm mainForm;
		private static IntPtr _hookID = IntPtr.Zero;
		
		[STAThread]
		private static void Main()
		{
			// my test-configuration
			keyConfiguration.Assign(Actions.Turbo, KeyConfiguration.QWERTY_SCANCODE_SPACE);
			keyConfiguration.Assign(Actions.Acceleration, KeyConfiguration.QWERTY_SCANCODE_S);
			keyConfiguration.Assign(Actions.RollLeft, KeyConfiguration.QWERTY_SCANCODE_A);
			keyConfiguration.Assign(Actions.RollRight, KeyConfiguration.QWERTY_SCANCODE_D);
			keyConfiguration.Assign(Actions.PowerUp, QWERTY_SCANCODE_NUMPAD0);
			keyConfiguration.Assign(Actions.TurnLeft, KeyConfiguration.QWERTY_SCANCODE_LEFT);
			keyConfiguration.Assign(Actions.TurnRight, KeyConfiguration.QWERTY_SCANCODE_RIGHT);
			
			Debug.WriteLine("Main");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			mainForm = new MainForm(keyConfiguration);
			try {
				_hookID = SetHook(HookCallback);
				Application.Run(mainForm);
			} finally {
				Extern.UnhookWindowsHookEx(_hookID);
			}
		}
		
		private static IntPtr SetHook(Extern.LowLevelKeyboardProc proc)
		{
			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule) {
				return Extern.SetWindowsHookEx(Extern.WH_KEYBOARD_LL, proc, Extern.GetModuleHandle(curModule.ModuleName), 0);
			}
		}
		
		private static IntPtr HookCallback(int nCode, IntPtr wParam, ref Extern.KBDLLHOOKSTRUCT kbd)
		{
			if (nCode >= 0) {
				if (mainForm.HandleKeyEvent((int)wParam, kbd))
					return (IntPtr)1;
				
				bool isScrollLock = Extern.GetKeyState((int)Keys.Scroll) != 0;
				if (isScrollLock && RedirectKey((int)wParam, kbd))
					return (IntPtr)1;
			}
			
			return Extern.CallNextHookEx(_hookID, nCode, wParam, ref kbd);
		}
		
		private static bool RedirectKey(int eventType, Extern.KBDLLHOOKSTRUCT kbd)
		{
			bool isInjected = kbd.flags.HasFlag(Extern.KBDLLHOOKSTRUCTFlags.LLKHF_INJECTED);
			if (isInjected)
				return false;
			
			bool isKeyUp;
			switch (eventType) {
				case Extern.WM_KEYDOWN:
				case Extern.WM_SYSKEYDOWN:
					isKeyUp = false;
					break;
				case Extern.WM_KEYUP:
				case Extern.WM_SYSKEYUP:
					isKeyUp = true;
					break;
				default:
					return false;
			}
			
			bool isExtended = kbd.flags.HasFlag(Extern.KBDLLHOOKSTRUCTFlags.LLKHF_EXTENDED);
			return keyConfiguration.SendAssignedKey((byte)(kbd.scanCode & 0xff), isExtended, isKeyUp);
		}

	}
	
}
