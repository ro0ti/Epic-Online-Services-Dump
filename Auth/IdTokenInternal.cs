using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200065B RID: 1627
	[Token(Token = "0x200065B")]
	internal struct IdTokenInternal : IGettable<IdToken>, ISettable<IdToken>, IDisposable
	{
		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C1D")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x60029A8")]
			[Address(RVA = "0x55BAE0", Offset = "0x55A0E0", VA = "0x18055BAE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029A9")]
			[Address(RVA = "0x55BCC0", Offset = "0x55A2C0", VA = "0x18055BCC0")]
			set
			{
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C1E")]
		public Utf8String JsonWebToken
		{
			[Token(Token = "0x60029AA")]
			[Address(RVA = "0x55BB60", Offset = "0x55A160", VA = "0x18055BB60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029AB")]
			[Address(RVA = "0x55BD80", Offset = "0x55A380", VA = "0x18055BD80")]
			set
			{
			}
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x55B960", Offset = "0x559F60", VA = "0x18055B960", Slot = "5")]
		public void Set(ref IdToken other)
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x55B740", Offset = "0x559D40", VA = "0x18055B740", Slot = "6")]
		public void Set(ref IdToken? other)
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x55B640", Offset = "0x559C40", VA = "0x18055B640", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x55B720", Offset = "0x559D20", VA = "0x18055B720", Slot = "4")]
		public void Get(out IdToken output)
		{
		}

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001223")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AccountId;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_JsonWebToken;
	}
}
