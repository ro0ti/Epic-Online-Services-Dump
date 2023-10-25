using System;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	internal struct RequestToJoinResponseReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<RequestToJoinResponseReceivedCallbackInfo>, ISettable<RequestToJoinResponseReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B1C")]
		public object ClientData
		{
			[Token(Token = "0x6002668")]
			[Address(RVA = "0x566370", Offset = "0x564970", VA = "0x180566370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002669")]
			[Address(RVA = "0x5664E0", Offset = "0x564AE0", VA = "0x1805664E0")]
			set
			{
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x00009D04 File Offset: 0x00007F04
		[Token(Token = "0x17000B1D")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600266A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600266C RID: 9836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B1E")]
		public ProductUserId FromUserId
		{
			[Token(Token = "0x600266B")]
			[Address(RVA = "0x5663E0", Offset = "0x5649E0", VA = "0x1805663E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600266C")]
			[Address(RVA = "0x566540", Offset = "0x564B40", VA = "0x180566540")]
			set
			{
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B1F")]
		public ProductUserId ToUserId
		{
			[Token(Token = "0x600266D")]
			[Address(RVA = "0x566460", Offset = "0x564A60", VA = "0x180566460")]
			get
			{
				return null;
			}
			[Token(Token = "0x600266E")]
			[Address(RVA = "0x5665A0", Offset = "0x564BA0", VA = "0x1805665A0")]
			set
			{
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x00009D1C File Offset: 0x00007F1C
		// (set) Token: 0x06002670 RID: 9840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B20")]
		public RequestToJoinResponse Response
		{
			[Token(Token = "0x600266F")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return RequestToJoinResponse.Accepted;
			}
			[Token(Token = "0x6002670")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x5660F0", Offset = "0x5646F0", VA = "0x1805660F0", Slot = "6")]
		public void Set(ref RequestToJoinResponseReceivedCallbackInfo other)
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x5661F0", Offset = "0x5647F0", VA = "0x1805661F0", Slot = "7")]
		public void Set(ref RequestToJoinResponseReceivedCallbackInfo? other)
		{
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x566070", Offset = "0x564670", VA = "0x180566070", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x5660D0", Offset = "0x5646D0", VA = "0x1805660D0", Slot = "5")]
		public void Get(out RequestToJoinResponseReceivedCallbackInfo output)
		{
		}

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_FromUserId;

		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ToUserId;

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x18")]
		private RequestToJoinResponse m_Response;
	}
}
