using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable
	{
		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0000806C File Offset: 0x0000626C
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000829")]
		public Result ResultCode
		{
			[Token(Token = "0x6001D3D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D3E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700082A")]
		public object ClientData
		{
			[Token(Token = "0x6001D3F")]
			[Address(RVA = "0x535420", Offset = "0x533A20", VA = "0x180535420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0x535500", Offset = "0x533B00", VA = "0x180535500")]
			set
			{
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00008084 File Offset: 0x00006284
		[Token(Token = "0x1700082B")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001D41")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700082C")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x535490", Offset = "0x533A90", VA = "0x180535490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D43")]
			[Address(RVA = "0x535560", Offset = "0x533B60", VA = "0x180535560")]
			set
			{
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x535360", Offset = "0x533960", VA = "0x180535360", Slot = "6")]
		public void Set(ref RejectInviteCallbackInfo other)
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x535240", Offset = "0x533840", VA = "0x180535240", Slot = "7")]
		public void Set(ref RejectInviteCallbackInfo? other)
		{
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x5351C0", Offset = "0x5337C0", VA = "0x1805351C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x535220", Offset = "0x533820", VA = "0x180535220", Slot = "5")]
		public void Get(out RejectInviteCallbackInfo output)
		{
		}

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_InviteId;
	}
}
