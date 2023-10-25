using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	internal struct InfoInternal : IGettable<Info>, ISettable<Info>, IDisposable
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00005894 File Offset: 0x00003A94
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F0")]
		public Status Status
		{
			[Token(Token = "0x60012C7")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return Status.Offline;
			}
			[Token(Token = "0x60012C8")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F1")]
		public EpicAccountId UserId
		{
			[Token(Token = "0x60012C9")]
			[Address(RVA = "0x4F3300", Offset = "0x4F1900", VA = "0x1804F3300")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012CA")]
			[Address(RVA = "0x4F3640", Offset = "0x4F1C40", VA = "0x1804F3640")]
			set
			{
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F2")]
		public Utf8String ProductId
		{
			[Token(Token = "0x60012CB")]
			[Address(RVA = "0x4F30B0", Offset = "0x4F16B0", VA = "0x1804F30B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012CC")]
			[Address(RVA = "0x4F3440", Offset = "0x4F1A40", VA = "0x1804F3440")]
			set
			{
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F3")]
		public Utf8String ProductVersion
		{
			[Token(Token = "0x60012CD")]
			[Address(RVA = "0x4F3190", Offset = "0x4F1790", VA = "0x1804F3190")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012CE")]
			[Address(RVA = "0x4F3500", Offset = "0x4F1B00", VA = "0x1804F3500")]
			set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F4")]
		public Utf8String Platform
		{
			[Token(Token = "0x60012CF")]
			[Address(RVA = "0x4F3040", Offset = "0x4F1640", VA = "0x1804F3040")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D0")]
			[Address(RVA = "0x4F33E0", Offset = "0x4F19E0", VA = "0x1804F33E0")]
			set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F5")]
		public Utf8String RichText
		{
			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x4F3290", Offset = "0x4F1890", VA = "0x1804F3290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D2")]
			[Address(RVA = "0x4F35E0", Offset = "0x4F1BE0", VA = "0x1804F35E0")]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F6")]
		public DataRecord[] Records
		{
			[Token(Token = "0x60012D3")]
			[Address(RVA = "0x4F3200", Offset = "0x4F1800", VA = "0x1804F3200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D4")]
			[Address(RVA = "0x4F3560", Offset = "0x4F1B60", VA = "0x1804F3560")]
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F7")]
		public Utf8String ProductName
		{
			[Token(Token = "0x60012D5")]
			[Address(RVA = "0x4F3120", Offset = "0x4F1720", VA = "0x1804F3120")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D6")]
			[Address(RVA = "0x4F34A0", Offset = "0x4F1AA0", VA = "0x1804F34A0")]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004F8")]
		public Utf8String IntegratedPlatform
		{
			[Token(Token = "0x60012D7")]
			[Address(RVA = "0x4F2FD0", Offset = "0x4F15D0", VA = "0x1804F2FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D8")]
			[Address(RVA = "0x4F3380", Offset = "0x4F1980", VA = "0x1804F3380")]
			set
			{
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x4F2AA0", Offset = "0x4F10A0", VA = "0x1804F2AA0", Slot = "5")]
		public void Set(ref Info other)
		{
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x4F2CD0", Offset = "0x4F12D0", VA = "0x1804F2CD0", Slot = "6")]
		public void Set(ref Info? other)
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x4F29D0", Offset = "0x4F0FD0", VA = "0x1804F29D0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x4F2A70", Offset = "0x4F1070", VA = "0x1804F2A70", Slot = "4")]
		public void Get(out Info output)
		{
		}

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x4")]
		private Status m_Status;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ProductId;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ProductVersion;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Platform;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_RichText;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x30")]
		private int m_RecordsCount;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_Records;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_ProductName;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_IntegratedPlatform;
	}
}
