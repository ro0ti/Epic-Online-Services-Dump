using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	internal struct Vec3fInternal : IGettable<Vec3f>, ISettable<Vec3f>, IDisposable
	{
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x0000BBDC File Offset: 0x00009DDC
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D8F")]
		public float x
		{
			[Token(Token = "0x6002D7C")]
			[Address(RVA = "0x442C60", Offset = "0x441260", VA = "0x180442C60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D7D")]
			[Address(RVA = "0x57C9F0", Offset = "0x57AFF0", VA = "0x18057C9F0")]
			set
			{
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D90")]
		public float y
		{
			[Token(Token = "0x6002D7E")]
			[Address(RVA = "0x57C9C0", Offset = "0x57AFC0", VA = "0x18057C9C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D7F")]
			[Address(RVA = "0x57CA00", Offset = "0x57B000", VA = "0x18057CA00")]
			set
			{
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x0000BC0C File Offset: 0x00009E0C
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D91")]
		public float z
		{
			[Token(Token = "0x6002D80")]
			[Address(RVA = "0x57C9D0", Offset = "0x57AFD0", VA = "0x18057C9D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002D81")]
			[Address(RVA = "0x57CA10", Offset = "0x57B010", VA = "0x18057CA10")]
			set
			{
			}
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D82")]
		[Address(RVA = "0x4ACC40", Offset = "0x4AB240", VA = "0x1804ACC40", Slot = "5")]
		public void Set(ref Vec3f other)
		{
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D83")]
		[Address(RVA = "0x580730", Offset = "0x57ED30", VA = "0x180580730", Slot = "6")]
		public void Set(ref Vec3f? other)
		{
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D84")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x4ACB80", Offset = "0x4AB180", VA = "0x1804ACB80", Slot = "4")]
		public void Get(out Vec3f output)
		{
		}

		// Token: 0x04001433 RID: 5171
		[Token(Token = "0x4001433")]
		[FieldOffset(Offset = "0x0")]
		private float m_x;

		// Token: 0x04001434 RID: 5172
		[Token(Token = "0x4001434")]
		[FieldOffset(Offset = "0x4")]
		private float m_y;

		// Token: 0x04001435 RID: 5173
		[Token(Token = "0x4001435")]
		[FieldOffset(Offset = "0x8")]
		private float m_z;
	}
}
