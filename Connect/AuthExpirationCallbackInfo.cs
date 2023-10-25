using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	public struct AuthExpirationCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B4C")]
		public object ClientData
		{
			[Token(Token = "0x60026E3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026E4")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B4D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60026E5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60026E6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00009E54 File Offset: 0x00008054
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x553340", Offset = "0x551940", VA = "0x180553340")]
		internal void Set(ref AuthExpirationCallbackInfoInternal other)
		{
		}
	}
}
