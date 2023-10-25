using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200068A RID: 1674
	[Token(Token = "0x200068A")]
	internal struct VerifyUserAuthCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyUserAuthCallbackInfo>, ISettable<VerifyUserAuthCallbackInfo>, IDisposable
	{
		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x0000AC04 File Offset: 0x00008E04
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C9F")]
		public Result ResultCode
		{
			[Token(Token = "0x6002B1F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002B20")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA0")]
		public object ClientData
		{
			[Token(Token = "0x6002B21")]
			[Address(RVA = "0x582120", Offset = "0x580720", VA = "0x180582120")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B22")]
			[Address(RVA = "0x582190", Offset = "0x580790", VA = "0x180582190")]
			set
			{
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0000AC1C File Offset: 0x00008E1C
		[Token(Token = "0x17000CA1")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002B23")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x582000", Offset = "0x580600", VA = "0x180582000", Slot = "6")]
		public void Set(ref VerifyUserAuthCallbackInfo other)
		{
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B25")]
		[Address(RVA = "0x582060", Offset = "0x580660", VA = "0x180582060", Slot = "7")]
		public void Set(ref VerifyUserAuthCallbackInfo? other)
		{
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B26")]
		[Address(RVA = "0x581F90", Offset = "0x580590", VA = "0x180581F90", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x581FE0", Offset = "0x5805E0", VA = "0x180581FE0", Slot = "5")]
		public void Get(out VerifyUserAuthCallbackInfo output)
		{
		}

		// Token: 0x040012B6 RID: 4790
		[Token(Token = "0x40012B6")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040012B7 RID: 4791
		[Token(Token = "0x40012B7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
