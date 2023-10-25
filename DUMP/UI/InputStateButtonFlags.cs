using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Flags]
	public enum InputStateButtonFlags
	{
		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		None = 0,
		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		DPadLeft = 1,
		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		DPadRight = 2,
		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		DPadDown = 4,
		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		DPadUp = 8,
		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		FaceButtonLeft = 16,
		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		FaceButtonRight = 32,
		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		FaceButtonBottom = 64,
		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		FaceButtonTop = 128,
		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		LeftShoulder = 256,
		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		RightShoulder = 512,
		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		LeftTrigger = 1024,
		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		RightTrigger = 2048,
		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		SpecialLeft = 4096,
		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		SpecialRight = 8192,
		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		LeftThumbstick = 16384
	}
}
