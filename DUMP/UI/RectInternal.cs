using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	internal struct RectInternal : IGettable<Rect>, ISettable<Rect>, IDisposable
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00002B7C File Offset: 0x00000D7C
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C3")]
		public int X
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00002B94 File Offset: 0x00000D94
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C4")]
		public int Y
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00002BAC File Offset: 0x00000DAC
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C5")]
		public uint Width
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00002BC4 File Offset: 0x00000DC4
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C6")]
		public uint Height
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x4AF730", Offset = "0x4ADD30", VA = "0x1804AF730", Slot = "5")]
		public void Set(ref Rect other)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x4AF660", Offset = "0x4ADC60", VA = "0x1804AF660", Slot = "6")]
		public void Set(ref Rect? other)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x4AF640", Offset = "0x4ADC40", VA = "0x1804AF640", Slot = "4")]
		public void Get(out Rect output)
		{
		}

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x4")]
		private int m_X;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x8")]
		private int m_Y;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0xC")]
		private uint m_Width;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Height;
	}
}
