using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	public struct UpdateSendingOptions
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FB6")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E1")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FB7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FB8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0000506C File Offset: 0x0000326C
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003E2")]
		public RTCAudioStatus AudioStatus
		{
			[Token(Token = "0x6000FB9")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return RTCAudioStatus.Unsupported;
			}
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
