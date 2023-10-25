using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	internal struct LogoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<LogoutCallbackInfo>, ISettable<LogoutCallbackInfo>, IDisposable
	{
		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x0000A9AC File Offset: 0x00008BAC
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C51")]
		public Result ResultCode
		{
			[Token(Token = "0x6002A25")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002A26")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C52")]
		public object ClientData
		{
			[Token(Token = "0x6002A27")]
			[Address(RVA = "0x55FB00", Offset = "0x55E100", VA = "0x18055FB00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A28")]
			[Address(RVA = "0x55FBF0", Offset = "0x55E1F0", VA = "0x18055FBF0")]
			set
			{
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		[Token(Token = "0x17000C53")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002A29")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C54")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A2A")]
			[Address(RVA = "0x55FB70", Offset = "0x55E170", VA = "0x18055FB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A2B")]
			[Address(RVA = "0x55FC50", Offset = "0x55E250", VA = "0x18055FC50")]
			set
			{
			}
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x55FA40", Offset = "0x55E040", VA = "0x18055FA40", Slot = "6")]
		public void Set(ref LogoutCallbackInfo other)
		{
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x55F920", Offset = "0x55DF20", VA = "0x18055F920", Slot = "7")]
		public void Set(ref LogoutCallbackInfo? other)
		{
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x55F8A0", Offset = "0x55DEA0", VA = "0x18055F8A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x55F900", Offset = "0x55DF00", VA = "0x18055F900", Slot = "5")]
		public void Get(out LogoutCallbackInfo output)
		{
		}

		// Token: 0x04001266 RID: 4710
		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04001267 RID: 4711
		[Token(Token = "0x4001267")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001268 RID: 4712
		[Token(Token = "0x4001268")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
