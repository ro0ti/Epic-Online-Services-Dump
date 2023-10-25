using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	internal struct QuatInternal : IGettable<Quat>, ISettable<Quat>, IDisposable
	{
		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x0000BA8C File Offset: 0x00009C8C
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D74")]
		public float w
		{
			[Token(Token = "0x6002D3B")]
			[Address(RVA = "0x442C60", Offset = "0x441260", VA = "0x180442C60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D3C")]
			[Address(RVA = "0x57C9F0", Offset = "0x57AFF0", VA = "0x18057C9F0")]
			set
			{
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D75")]
		public float x
		{
			[Token(Token = "0x6002D3D")]
			[Address(RVA = "0x57C9C0", Offset = "0x57AFC0", VA = "0x18057C9C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D3E")]
			[Address(RVA = "0x57CA00", Offset = "0x57B000", VA = "0x18057CA00")]
			set
			{
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x0000BABC File Offset: 0x00009CBC
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D76")]
		public float y
		{
			[Token(Token = "0x6002D3F")]
			[Address(RVA = "0x57C9D0", Offset = "0x57AFD0", VA = "0x18057C9D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D40")]
			[Address(RVA = "0x57CA10", Offset = "0x57B010", VA = "0x18057CA10")]
			set
			{
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D77")]
		public float z
		{
			[Token(Token = "0x6002D41")]
			[Address(RVA = "0x57C9E0", Offset = "0x57AFE0", VA = "0x18057C9E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D42")]
			[Address(RVA = "0x57CA20", Offset = "0x57B020", VA = "0x18057CA20")]
			set
			{
			}
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x57C8D0", Offset = "0x57AED0", VA = "0x18057C8D0", Slot = "5")]
		public void Set(ref Quat other)
		{
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x57C8F0", Offset = "0x57AEF0", VA = "0x18057C8F0", Slot = "6")]
		public void Set(ref Quat? other)
		{
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D45")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x57C8B0", Offset = "0x57AEB0", VA = "0x18057C8B0", Slot = "4")]
		public void Get(out Quat output)
		{
		}

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0x0")]
		private float m_w;

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0x4")]
		private float m_x;

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x8")]
		private float m_y;

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0xC")]
		private float m_z;
	}
}
