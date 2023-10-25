using System;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005E5 RID: 1509
	[Token(Token = "0x20005E5")]
	internal struct SendRequestToJoinOptionsInternal : ISettable<SendRequestToJoinOptions>, IDisposable
	{
		// Token: 0x17000B46 RID: 2886
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B46")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60026CF")]
			[Address(RVA = "0x5682F0", Offset = "0x5668F0", VA = "0x1805682F0")]
			set
			{
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B47")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60026D0")]
			[Address(RVA = "0x568350", Offset = "0x566950", VA = "0x180568350")]
			set
			{
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x568120", Offset = "0x566720", VA = "0x180568120", Slot = "4")]
		public void Set(ref SendRequestToJoinOptions other)
		{
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x5681E0", Offset = "0x5667E0", VA = "0x1805681E0", Slot = "5")]
		public void Set(ref SendRequestToJoinOptions? other)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x5680C0", Offset = "0x5666C0", VA = "0x1805680C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010FF RID: 4351
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
