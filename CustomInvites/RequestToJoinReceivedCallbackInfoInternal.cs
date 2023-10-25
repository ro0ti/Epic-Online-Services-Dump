using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005D8 RID: 1496
	[Token(Token = "0x20005D8")]
	internal struct RequestToJoinReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<RequestToJoinReceivedCallbackInfo>, ISettable<RequestToJoinReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B14")]
		public object ClientData
		{
			[Token(Token = "0x6002653")]
			[Address(RVA = "0x565D20", Offset = "0x564320", VA = "0x180565D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002654")]
			[Address(RVA = "0x565E90", Offset = "0x564490", VA = "0x180565E90")]
			set
			{
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x00009CBC File Offset: 0x00007EBC
		[Token(Token = "0x17000B15")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002655")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B16")]
		public ProductUserId FromUserId
		{
			[Token(Token = "0x6002656")]
			[Address(RVA = "0x565D90", Offset = "0x564390", VA = "0x180565D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002657")]
			[Address(RVA = "0x565EF0", Offset = "0x5644F0", VA = "0x180565EF0")]
			set
			{
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B17")]
		public ProductUserId ToUserId
		{
			[Token(Token = "0x6002658")]
			[Address(RVA = "0x565E10", Offset = "0x564410", VA = "0x180565E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002659")]
			[Address(RVA = "0x565F50", Offset = "0x564550", VA = "0x180565F50")]
			set
			{
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x565AC0", Offset = "0x5640C0", VA = "0x180565AC0", Slot = "6")]
		public void Set(ref RequestToJoinReceivedCallbackInfo other)
		{
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x565BC0", Offset = "0x5641C0", VA = "0x180565BC0", Slot = "7")]
		public void Set(ref RequestToJoinReceivedCallbackInfo? other)
		{
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x565A40", Offset = "0x564040", VA = "0x180565A40", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600265D")]
		[Address(RVA = "0x565AA0", Offset = "0x5640A0", VA = "0x180565AA0", Slot = "5")]
		public void Get(out RequestToJoinReceivedCallbackInfo output)
		{
		}

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_FromUserId;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ToUserId;
	}
}
