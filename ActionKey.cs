using System;
using System.Windows.Forms;

namespace keyout
{
	public struct ActionKey {
		public static readonly ActionKey NONE = new ActionKey(Keys.None, 0);
		
		public readonly Keys key;
		public readonly byte scanCode;
		public readonly bool isExtended;
		
		public ActionKey(Keys key, byte scanCode, bool isExtended) {
			this.key = key;
			this.scanCode = scanCode;
			this.isExtended = isExtended;
		}
		
		public ActionKey(Keys key, uint extendedScanCode): this(key, (byte) (extendedScanCode & 0xff), (extendedScanCode >> 8) != 0) {
			
		}
		
		public static ActionKey ForScanCode(byte scanCode, bool isExtended) {
			var extendedScanCode = (isExtended ? 0xe000u : 0x0000u) | scanCode;
			var key = (Keys) Extern.MapVirtualKeyEx(extendedScanCode, Extern.MapVirtualKeyMapTypes.MAPVK_VSC_TO_VK_EX, (IntPtr) 0);
			return new ActionKey(key, scanCode, isExtended);
		}
		
		public static ActionKey ForScanCode(uint extendedScanCode) {
			var key = (Keys) Extern.MapVirtualKeyEx(extendedScanCode, Extern.MapVirtualKeyMapTypes.MAPVK_VSC_TO_VK_EX, (IntPtr) 0);
			return new ActionKey(key, extendedScanCode);
		}
		
		public bool SendKey(bool isKeyUp) {
			return SendKey(this.key, this.scanCode, this.isExtended, isKeyUp);
		}
		
		private static bool SendKey(Keys virtualKey, byte scanCode, bool isExtended, bool isKeyUp)
		{
			if (virtualKey == Keys.None) return false;
			if (scanCode == 0) return false;
			Extern.KEYEVENTFlags flags = (isExtended ? Extern.KEYEVENTFlags.KEYEVENTF_EXTENDEDKEY : 0) | (isKeyUp ? Extern.KEYEVENTFlags.KEYEVENTF_KEYUP : 0);
			Extern.keybd_event((byte) virtualKey, (byte) (scanCode & 0xff), (int)flags, 0);
			return true;
		}

	}

}
