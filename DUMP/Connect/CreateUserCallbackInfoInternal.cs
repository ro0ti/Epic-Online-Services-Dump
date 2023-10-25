using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	internal struct CreateUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateUserCallbackInfo>, ISettable<CreateUserCallbackInfo>, IDisposable
	{
		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x0000A04C File Offset: 0x0000824C
		// (set) Token: 0x0600275E RID: 10078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B6B")]
		public Result ResultCode
		{
			[Token(Token = "0x600275D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600275E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B6C")]
		public object ClientData
		{
			[Token(Token = "0x600275F")]
			[Address(RVA = "0x558BF0", Offset = "0x5571F0", VA = "0x180558BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002760")]
			[Address(RVA = "0x558CE0", Offset = "0x5572E0", VA = "0x180558CE0")]
			set
			{
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x0000A064 File Offset: 0x00008264
		[Token(Token = "0x17000B6D")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002761")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B6E")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002762")]
			[Address(RVA = "0x558C60", Offset = "0x557260", VA = "0x180558C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002763")]
			[Address(RVA = "0x558D40", Offset = "0x557340", VA = "0x180558D40")]
			set
			{
			}
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x558B30", Offset = "0x557130", VA = "0x180558B30", Slot = "6")]
		public void Set(ref CreateUserCallbackInfo other)
		{
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x558A10", Offset = "0x557010", VA = "0x180558A10", Slot = "7")]
		public void Set(ref CreateUserCallbackInfo? other)
		{
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x558990", Offset = "0x556F90", VA = "0x180558990", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x5589F0", Offset = "0x556FF0", VA = "0x1805589F0", Slot = "5")]
		public void Get(out CreateUserCallbackInfo output)
		{
		}

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
