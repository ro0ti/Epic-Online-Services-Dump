using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public struct CreateUserCallbackInfo : ICallbackInfo
	{
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00008654 File Offset: 0x00006854
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B6")]
		public Result ResultCode
		{
			[Token(Token = "0x6001ED3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001ED4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B7")]
		public object ClientData
		{
			[Token(Token = "0x6001ED5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001ED6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001ED7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001ED8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B9")]
		public Utf8String KWSUserId
		{
			[Token(Token = "0x6001ED9")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EDA")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0000866C File Offset: 0x0000686C
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008BA")]
		public bool IsMinor
		{
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00008684 File Offset: 0x00006884
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x5227A0", Offset = "0x520DA0", VA = "0x1805227A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x5227F0", Offset = "0x520DF0", VA = "0x1805227F0")]
		internal void Set(ref CreateUserCallbackInfoInternal other)
		{
		}
	}
}
