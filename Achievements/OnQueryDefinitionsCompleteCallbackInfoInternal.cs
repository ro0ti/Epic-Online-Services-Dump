using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	internal struct OnQueryDefinitionsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryDefinitionsCompleteCallbackInfo>, ISettable<OnQueryDefinitionsCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x060030B0 RID: 12464 RVA: 0x0000C8CC File Offset: 0x0000AACC
		// (set) Token: 0x060030B1 RID: 12465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA2")]
		public Result ResultCode
		{
			[Token(Token = "0x60030B0")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60030B1")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x060030B2 RID: 12466 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030B3 RID: 12467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA3")]
		public object ClientData
		{
			[Token(Token = "0x60030B2")]
			[Address(RVA = "0x589A00", Offset = "0x588000", VA = "0x180589A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60030B3")]
			[Address(RVA = "0x589A70", Offset = "0x588070", VA = "0x180589A70")]
			set
			{
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x060030B4 RID: 12468 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		[Token(Token = "0x17000EA4")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60030B4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x5899A0", Offset = "0x587FA0", VA = "0x1805899A0", Slot = "6")]
		public void Set(ref OnQueryDefinitionsCompleteCallbackInfo other)
		{
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030B6")]
		[Address(RVA = "0x5898E0", Offset = "0x587EE0", VA = "0x1805898E0", Slot = "7")]
		public void Set(ref OnQueryDefinitionsCompleteCallbackInfo? other)
		{
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030B7")]
		[Address(RVA = "0x589870", Offset = "0x587E70", VA = "0x180589870", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030B8")]
		[Address(RVA = "0x5898C0", Offset = "0x587EC0", VA = "0x1805898C0", Slot = "5")]
		public void Get(out OnQueryDefinitionsCompleteCallbackInfo output)
		{
		}

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
