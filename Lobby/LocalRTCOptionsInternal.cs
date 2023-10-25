using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000433 RID: 1075
	[Token(Token = "0x2000433")]
	internal struct LocalRTCOptionsInternal : IGettable<LocalRTCOptions>, ISettable<LocalRTCOptions>, IDisposable
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x00007F1C File Offset: 0x0000611C
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700080A")]
		public uint Flags
		{
			[Token(Token = "0x6001C3B")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00007F34 File Offset: 0x00006134
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700080B")]
		public bool UseManualAudioInput
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x52D540", Offset = "0x52BB40", VA = "0x18052D540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x52D660", Offset = "0x52BC60", VA = "0x18052D660")]
			set
			{
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00007F4C File Offset: 0x0000614C
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700080C")]
		public bool UseManualAudioOutput
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x52D5A0", Offset = "0x52BBA0", VA = "0x18052D5A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x52D6C0", Offset = "0x52BCC0", VA = "0x18052D6C0")]
			set
			{
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00007F64 File Offset: 0x00006164
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700080D")]
		public bool LocalAudioDeviceInputStartsMuted
		{
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x52D4E0", Offset = "0x52BAE0", VA = "0x18052D4E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x52D600", Offset = "0x52BC00", VA = "0x18052D600")]
			set
			{
			}
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x52D250", Offset = "0x52B850", VA = "0x18052D250", Slot = "5")]
		public void Set(ref LocalRTCOptions other)
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x52D360", Offset = "0x52B960", VA = "0x18052D360", Slot = "6")]
		public void Set(ref LocalRTCOptions? other)
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x52D230", Offset = "0x52B830", VA = "0x18052D230", Slot = "4")]
		public void Get(out LocalRTCOptions output)
		{
		}

		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x4")]
		private uint m_Flags;

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x8")]
		private int m_UseManualAudioInput;

		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		[FieldOffset(Offset = "0xC")]
		private int m_UseManualAudioOutput;

		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		[FieldOffset(Offset = "0x10")]
		private int m_LocalAudioDeviceInputStartsMuted;
	}
}
