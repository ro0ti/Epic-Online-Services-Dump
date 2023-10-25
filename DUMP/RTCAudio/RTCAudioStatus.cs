using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	public enum RTCAudioStatus
	{
		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		Unsupported,
		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		Enabled,
		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		Disabled,
		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		AdminDisabled,
		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		NotListeningDisabled
	}
}
