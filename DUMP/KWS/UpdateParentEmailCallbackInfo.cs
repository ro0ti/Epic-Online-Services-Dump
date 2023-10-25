using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	public struct UpdateParentEmailCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00008954 File Offset: 0x00006B54
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000903")]
		public Result ResultCode
		{
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000904")]
		public object ClientData
		{
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FD9")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FDB RID: 8155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000905")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0000896C File Offset: 0x00006B6C
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x538310", Offset = "0x536910", VA = "0x180538310", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x538360", Offset = "0x536960", VA = "0x180538360")]
		internal void Set(ref UpdateParentEmailCallbackInfoInternal other)
		{
		}
	}
}
