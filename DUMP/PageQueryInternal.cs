using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	internal struct PageQueryInternal : IGettable<PageQuery>, ISettable<PageQuery>, IDisposable
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000013")]
		public int StartIndex
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00002504 File Offset: 0x00000704
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public int MaxCount
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			set
			{
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x4ACAD0", Offset = "0x4AB0D0", VA = "0x1804ACAD0", Slot = "5")]
		public void Set(ref PageQuery other)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x4ACAF0", Offset = "0x4AB0F0", VA = "0x1804ACAF0", Slot = "6")]
		public void Set(ref PageQuery? other)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x4ACAB0", Offset = "0x4AB0B0", VA = "0x1804ACAB0", Slot = "4")]
		public void Get(out PageQuery output)
		{
		}

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x4")]
		private int m_StartIndex;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x8")]
		private int m_MaxCount;
	}
}
