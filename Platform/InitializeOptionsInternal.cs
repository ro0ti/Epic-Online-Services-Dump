using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Platform
{
	// Token: 0x0200072C RID: 1836
	[Token(Token = "0x200072C")]
	internal struct InitializeOptionsInternal : ISettable<InitializeOptions>, IDisposable
	{
		// Token: 0x17000DEC RID: 3564
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DEC")]
		public IntPtr AllocateMemoryFunction
		{
			[Token(Token = "0x6002EE8")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000DED RID: 3565
		// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DED")]
		public IntPtr ReallocateMemoryFunction
		{
			[Token(Token = "0x6002EE9")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DEE")]
		public IntPtr ReleaseMemoryFunction
		{
			[Token(Token = "0x6002EEA")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			set
			{
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (set) Token: 0x06002EEB RID: 12011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DEF")]
		public Utf8String ProductName
		{
			[Token(Token = "0x6002EEB")]
			[Address(RVA = "0x571590", Offset = "0x56FB90", VA = "0x180571590")]
			set
			{
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DF0")]
		public Utf8String ProductVersion
		{
			[Token(Token = "0x6002EEC")]
			[Address(RVA = "0x5715F0", Offset = "0x56FBF0", VA = "0x1805715F0")]
			set
			{
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (set) Token: 0x06002EED RID: 12013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DF1")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002EED")]
			[Address(RVA = "0x56BE20", Offset = "0x56A420", VA = "0x18056BE20")]
			set
			{
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DF2")]
		public IntPtr SystemInitializeOptions
		{
			[Token(Token = "0x6002EEE")]
			[Address(RVA = "0x55EEB0", Offset = "0x55D4B0", VA = "0x18055EEB0")]
			set
			{
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DF3")]
		public InitializeThreadAffinity? OverrideThreadAffinity
		{
			[Token(Token = "0x6002EEF")]
			[Address(RVA = "0x571520", Offset = "0x56FB20", VA = "0x180571520")]
			set
			{
			}
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EF0")]
		[Address(RVA = "0x5710D0", Offset = "0x56F6D0", VA = "0x1805710D0", Slot = "4")]
		public void Set(ref InitializeOptions other)
		{
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EF1")]
		[Address(RVA = "0x571230", Offset = "0x56F830", VA = "0x180571230", Slot = "5")]
		public void Set(ref InitializeOptions? other)
		{
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EF2")]
		[Address(RVA = "0x571030", Offset = "0x56F630", VA = "0x180571030", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040014F1 RID: 5361
		[Token(Token = "0x40014F1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040014F2 RID: 5362
		[Token(Token = "0x40014F2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AllocateMemoryFunction;

		// Token: 0x040014F3 RID: 5363
		[Token(Token = "0x40014F3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ReallocateMemoryFunction;

		// Token: 0x040014F4 RID: 5364
		[Token(Token = "0x40014F4")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ReleaseMemoryFunction;

		// Token: 0x040014F5 RID: 5365
		[Token(Token = "0x40014F5")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ProductName;

		// Token: 0x040014F6 RID: 5366
		[Token(Token = "0x40014F6")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_ProductVersion;

		// Token: 0x040014F7 RID: 5367
		[Token(Token = "0x40014F7")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_Reserved;

		// Token: 0x040014F8 RID: 5368
		[Token(Token = "0x40014F8")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_SystemInitializeOptions;

		// Token: 0x040014F9 RID: 5369
		[Token(Token = "0x40014F9")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_OverrideThreadAffinity;
	}
}
