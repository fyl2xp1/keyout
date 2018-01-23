using System;
using System.Windows.Forms;

namespace keyout
{
	public class KeyConfiguration
	{
		public const uint QWERTY_SCANCODE_M = 50;
		public const uint QWERTY_SCANCODE_X = 45;
		public const uint QWERTY_SCANCODE_TAB = 15;
		public const uint QWERTY_SCANCODE_ESCAPE = 1;
		public const uint QWERTY_SCANCODE_RETURN = 28;
		public const uint QWERTY_SCANCODE_SPACE = 57;
		public const uint QWERTY_SCANCODE_C = 46;
		public const uint QWERTY_SCANCODE_LSHIFTKEY = 42;
		public const uint QWERTY_SCANCODE_F = 33;
		public const uint QWERTY_SCANCODE_L = 38;
		public const uint QWERTY_SCANCODE_H = 35;
		public const uint QWERTY_SCANCODE_K = 37;
		public const uint QWERTY_SCANCODE_W = 17;
		public const uint QWERTY_SCANCODE_S = 31;
		public const uint QWERTY_SCANCODE_NUMPAD4 = 75;
		public const uint QWERTY_SCANCODE_NUMPAD6 = 77;
		public const uint QWERTY_SCANCODE_NUMPAD8 = 72;
		public const uint QWERTY_SCANCODE_NUMPAD2 = 80;
		public const uint QWERTY_SCANCODE_DOWN = 0xe000 | 80;
		public const uint QWERTY_SCANCODE_UP = 0xe000 | 72;
		public const uint QWERTY_SCANCODE_LEFT = 0xe000 | 75;
		public const uint QWERTY_SCANCODE_RIGHT = 0xe000 | 77;
		public const uint QWERTY_SCANCODE_A = 30;
		public const uint QWERTY_SCANCODE_D = 32;
		
		public static readonly KeyConfiguration REDOUT;
		static KeyConfiguration() {
			REDOUT = new KeyConfiguration();
			REDOUT.Assign(Actions.ChangeShipPalette,      QWERTY_SCANCODE_M);
			REDOUT.Assign(Actions.LookBack,               QWERTY_SCANCODE_X);
			REDOUT.Assign(Actions.OnlineStartRace,        QWERTY_SCANCODE_TAB);
			REDOUT.Assign(Actions.Pause,                  QWERTY_SCANCODE_ESCAPE);
			REDOUT.Assign(Actions.PlayerReady,            QWERTY_SCANCODE_RETURN);
			REDOUT.Assign(Actions.PowerUp,                QWERTY_SCANCODE_SPACE);
			REDOUT.Assign(Actions.ToggleCamera,           QWERTY_SCANCODE_C);
			REDOUT.Assign(Actions.Turbo,                  QWERTY_SCANCODE_LSHIFTKEY);
			REDOUT.Assign(Actions.MenuDebug,              QWERTY_SCANCODE_F);
			REDOUT.Assign(Actions.PassToAI,               QWERTY_SCANCODE_L);
			REDOUT.Assign(Actions.RemoveWallCollisions,   QWERTY_SCANCODE_H);
			REDOUT.Assign(Actions.SwitchConfigurationKey, QWERTY_SCANCODE_K);
			REDOUT.Assign(Actions.Acceleration,           QWERTY_SCANCODE_W);
			REDOUT.Assign(Actions.Brake,                  QWERTY_SCANCODE_S);
			REDOUT.Assign(Actions.MoveCameraLeft,  Keys.NumPad4, QWERTY_SCANCODE_NUMPAD4);
			REDOUT.Assign(Actions.MoveCameraRight, Keys.NumPad6, QWERTY_SCANCODE_NUMPAD6);
			REDOUT.Assign(Actions.MoveCameraFront, Keys.NumPad8, QWERTY_SCANCODE_NUMPAD8);
			REDOUT.Assign(Actions.MoveCameraBack,  Keys.NumPad2, QWERTY_SCANCODE_NUMPAD2);
			REDOUT.Assign(Actions.PitchUp,                QWERTY_SCANCODE_DOWN);
			REDOUT.Assign(Actions.PitchDown,              QWERTY_SCANCODE_UP);
			REDOUT.Assign(Actions.RollLeft,               QWERTY_SCANCODE_LEFT);
			REDOUT.Assign(Actions.RollRight,              QWERTY_SCANCODE_RIGHT);
			REDOUT.Assign(Actions.TurnLeft,               QWERTY_SCANCODE_A);
			REDOUT.Assign(Actions.TurnRight,              QWERTY_SCANCODE_D);
		}
		
		
		private readonly ActionKey[] actionKeys = new ActionKey[(int)Actions.Max];
		private readonly Actions[] scanCodeActions = new Actions[256];
		private readonly Actions[] extendedScanCodeActions = new Actions[256];
		
		public KeyConfiguration()
		{
		}
		
		public KeyConfiguration(KeyConfiguration template): this()
		{
			Array.Copy(template.actionKeys, this.actionKeys, actionKeys.Length);
			Array.Copy(template.scanCodeActions, this.scanCodeActions, scanCodeActions.Length);
			Array.Copy(template.extendedScanCodeActions, this.extendedScanCodeActions, extendedScanCodeActions.Length);
		}
		
		public void Assign(Actions action, uint extendedScanCode) {
			Assign(action, ActionKey.ForScanCode(extendedScanCode));
		}
		
		public void Assign(Actions action, byte scanCode, bool isExtended) {
			Assign(action, ActionKey.ForScanCode(scanCode, isExtended));
		}

		public void Assign(Actions action, Keys key, uint extendedScanCode) {
			Assign(action, new ActionKey(key, extendedScanCode));
		}

		public void Assign(Actions action, Keys key, byte scanCode, bool isExtended) {
			Assign(action, new ActionKey(key, scanCode, isExtended));
		}

		public void Assign(Actions action, ActionKey actionKey) {
			var actions = actionKey.isExtended ? extendedScanCodeActions : scanCodeActions;
			// remember the previously assigned key for the given action
			var oldKeyForAction = actionKeys[(int)action];
			// remember the previously assigned action for the given key
			var oldActionForKey = actions[actionKey.scanCode];
			// there shall never exist two keys being assigned to the same action  
			var oldActions = oldKeyForAction.isExtended ? extendedScanCodeActions : scanCodeActions;
			oldActions[oldKeyForAction.scanCode] = Actions.None;
			// there shall never exist two actions being assigned to the same key 
			actionKeys[(int)oldActionForKey] = ActionKey.NONE;
			// perform two-way assignment
			actions[actionKey.scanCode] = action;
			actionKeys[(int)action] = actionKey;
		}
		
		public void Reset(Actions action) {
			Assign(action, REDOUT.GetActionKey(action));
		}
		
		public ActionKey GetActionKey(Actions action) {
			return actionKeys[(int)action];
		}
		
		public bool SendAssignedKey(byte scanCode, bool isExtended, bool isKeyUp) {
			var actions = isExtended ? extendedScanCodeActions : scanCodeActions;
			var action = actions[scanCode];
			return action != Actions.None && REDOUT.actionKeys[(int)action].SendKey(isKeyUp);
		}
		
	}
}
