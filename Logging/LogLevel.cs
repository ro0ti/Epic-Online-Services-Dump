using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Logging
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	public enum LogLevel
	{
		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		Off,
		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		Fatal = 100,
		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		Error = 200,
		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		Warning = 300,
		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		Info = 400,
		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		Verbose = 500,
		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		VeryVerbose = 600
	}
}
