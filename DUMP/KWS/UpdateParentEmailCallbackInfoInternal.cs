using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	internal struct UpdateParentEmailCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateParentEmailCallbackInfo>, ISettable<UpdateParentEmailCallbackInfo>, IDisposable
	{
		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x00008984 File Offset: 0x00006B84
		// (set) Token: 0x06001FDF RID: 8159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000906")]
		public Result ResultCode
		{
			[Token(Token = "0x6001FDE")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001FDF")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000907")]
		public object ClientData
		{
			[Token(Token = "0x6001FE0")]
			[Address(RVA = "0x538160", Offset = "0x536760", VA = "0x180538160")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE1")]
			[Address(RVA = "0x538250", Offset = "0x536850", VA = "0x180538250")]
			set
			{
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x0000899C File Offset: 0x00006B9C
		[Token(Token = "0x17000908")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001FE2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000909")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FE3")]
			[Address(RVA = "0x5381D0", Offset = "0x5367D0", VA = "0x1805381D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE4")]
			[Address(RVA = "0x5382B0", Offset = "0x5368B0", VA = "0x1805382B0")]
			set
			{
			}
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x537F80", Offset = "0x536580", VA = "0x180537F80", Slot = "6")]
		public void Set(ref UpdateParentEmailCallbackInfo other)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x538040", Offset = "0x536640", VA = "0x180538040", Slot = "7")]
		public void Set(ref UpdateParentEmailCallbackInfo? other)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x537F00", Offset = "0x536500", VA = "0x180537F00", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x537F60", Offset = "0x536560", VA = "0x180537F60", Slot = "5")]
		public void Get(out UpdateParentEmailCallbackInfo output)
		{
		}

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
