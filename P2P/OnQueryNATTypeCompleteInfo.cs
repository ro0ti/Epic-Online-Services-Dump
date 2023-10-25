using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	public struct OnQueryNATTypeCompleteInfo : ICallbackInfo
	{
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x00006494 File Offset: 0x00004694
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000617")]
		public Result ResultCode
		{
			[Token(Token = "0x6001671")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000618")]
		public object ClientData
		{
			[Token(Token = "0x6001673")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001674")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x000064AC File Offset: 0x000046AC
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000619")]
		public NATType NATType
		{
			[Token(Token = "0x6001675")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return NATType.Unknown;
			}
			[Token(Token = "0x6001676")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000064C4 File Offset: 0x000046C4
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x51C3C0", Offset = "0x51A9C0", VA = "0x18051C3C0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x51C410", Offset = "0x51AA10", VA = "0x18051C410")]
		internal void Set(ref OnQueryNATTypeCompleteInfoInternal other)
		{
		}
	}
}
