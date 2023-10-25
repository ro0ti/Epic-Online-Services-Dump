using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Logging
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public struct LogMessage
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B5")]
		public Utf8String Category
		{
			[Token(Token = "0x6001851")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001852")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B6")]
		public Utf8String Message
		{
			[Token(Token = "0x6001853")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001854")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00006E54 File Offset: 0x00005054
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006B7")]
		public LogLevel Level
		{
			[Token(Token = "0x6001855")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LogLevel.Off;
			}
			[Token(Token = "0x6001856")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x517D80", Offset = "0x516380", VA = "0x180517D80")]
		internal void Set(ref LogMessageInternal other)
		{
		}
	}
}
