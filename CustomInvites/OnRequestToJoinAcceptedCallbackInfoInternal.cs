using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	internal struct OnRequestToJoinAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnRequestToJoinAcceptedCallbackInfo>, ISettable<OnRequestToJoinAcceptedCallbackInfo>, IDisposable
	{
		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025DE RID: 9694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AF9")]
		public object ClientData
		{
			[Token(Token = "0x60025DD")]
			[Address(RVA = "0x562C10", Offset = "0x561210", VA = "0x180562C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025DE")]
			[Address(RVA = "0x562D80", Offset = "0x561380", VA = "0x180562D80")]
			set
			{
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x00009BFC File Offset: 0x00007DFC
		[Token(Token = "0x17000AFA")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60025DF")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AFB")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60025E0")]
			[Address(RVA = "0x562D00", Offset = "0x561300", VA = "0x180562D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025E1")]
			[Address(RVA = "0x562E40", Offset = "0x561440", VA = "0x180562E40")]
			set
			{
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AFC")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60025E2")]
			[Address(RVA = "0x562C80", Offset = "0x561280", VA = "0x180562C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025E3")]
			[Address(RVA = "0x562DE0", Offset = "0x5613E0", VA = "0x180562DE0")]
			set
			{
			}
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x562B10", Offset = "0x561110", VA = "0x180562B10", Slot = "6")]
		public void Set(ref OnRequestToJoinAcceptedCallbackInfo other)
		{
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x5629B0", Offset = "0x560FB0", VA = "0x1805629B0", Slot = "7")]
		public void Set(ref OnRequestToJoinAcceptedCallbackInfo? other)
		{
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x562930", Offset = "0x560F30", VA = "0x180562930", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x562990", Offset = "0x560F90", VA = "0x180562990", Slot = "5")]
		public void Get(out OnRequestToJoinAcceptedCallbackInfo output)
		{
		}

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
