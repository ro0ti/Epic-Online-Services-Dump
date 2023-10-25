using System;


namespace Epic.OnlineServices.Platform
{
	// Token: 0x0200071E RID: 1822
	[Token(Token = "0x200071E")]
	internal struct AndroidInitializeOptionsInternal : ISettable<AndroidInitializeOptions>, IDisposable
	{
		// Token: 0x17000DCE RID: 3534
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DCE")]
		public IntPtr AllocateMemoryFunction
		{
			[Token(Token = "0x6002E68")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (set) Token: 0x06002E69 RID: 11881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DCF")]
		public IntPtr ReallocateMemoryFunction
		{
			[Token(Token = "0x6002E69")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD0")]
		public IntPtr ReleaseMemoryFunction
		{
			[Token(Token = "0x6002E6A")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			set
			{
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (set) Token: 0x06002E6B RID: 11883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD1")]
		public Utf8String ProductName
		{
			[Token(Token = "0x6002E6B")]
			[Address(RVA = "0x56BD60", Offset = "0x56A360", VA = "0x18056BD60")]
			set
			{
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD2")]
		public Utf8String ProductVersion
		{
			[Token(Token = "0x6002E6C")]
			[Address(RVA = "0x56BDC0", Offset = "0x56A3C0", VA = "0x18056BDC0")]
			set
			{
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD3")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002E6D")]
			[Address(RVA = "0x56BE20", Offset = "0x56A420", VA = "0x18056BE20")]
			set
			{
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD4")]
		public AndroidInitializeOptionsSystemInitializeOptions? SystemInitializeOptions
		{
			[Token(Token = "0x6002E6E")]
			[Address(RVA = "0x56BE30", Offset = "0x56A430", VA = "0x18056BE30")]
			set
			{
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (set) Token: 0x06002E6F RID: 11887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD5")]
		public InitializeThreadAffinity? OverrideThreadAffinity
		{
			[Token(Token = "0x6002E6F")]
			[Address(RVA = "0x56BCF0", Offset = "0x56A2F0", VA = "0x18056BCF0")]
			set
			{
			}
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x56B730", Offset = "0x569D30", VA = "0x18056B730", Slot = "4")]
		public void Set(ref AndroidInitializeOptions other)
		{
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x56B9B0", Offset = "0x569FB0", VA = "0x18056B9B0", Slot = "5")]
		public void Set(ref AndroidInitializeOptions? other)
		{
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E72")]
		[Address(RVA = "0x56B690", Offset = "0x569C90", VA = "0x18056B690", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AllocateMemoryFunction;

		// Token: 0x040014AF RID: 5295
		[Token(Token = "0x40014AF")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ReallocateMemoryFunction;

		// Token: 0x040014B0 RID: 5296
		[Token(Token = "0x40014B0")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ReleaseMemoryFunction;

		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40014B1")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ProductName;

		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40014B2")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_ProductVersion;

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_Reserved;

		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40014B4")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_SystemInitializeOptions;

		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_OverrideThreadAffinity;
	}
}
