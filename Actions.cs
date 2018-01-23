using System;

namespace keyout
{
	public enum Actions {
		None,
		ChangeShipPalette, // unused, = 0
		LookBack,
		OnlineStartRace, // unused
		Pause,
		PlayerReady, // unused
		PowerUp,
		ToggleCamera,
		Turbo,
		MenuDebug, // unused
		PassToAI, // unused
		RemoveWallCollisions, // unused
		SwitchConfigurationKey, // unused
		
		Acceleration, Brake,
		MoveCameraLeft, MoveCameraRight,
		MoveCameraFront, MoveCameraBack,
		PitchUp, PitchDown,
		RollLeft, RollRight,
		TurnLeft, TurnRight,
	}
}
