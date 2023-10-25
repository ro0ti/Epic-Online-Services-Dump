using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	internal struct AudioBufferInternal : IGettable<AudioBuffer>, ISettable<AudioBuffer>, IDisposable
	{
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000309")]
		public short[] Frames
		{
			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x4D5A90", Offset = "0x4D4090", VA = "0x1804D5A90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x4D5B20", Offset = "0x4D4120", VA = "0x1804D5B20")]
			set
			{
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00004694 File Offset: 0x00002894
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700030A")]
		public uint SampleRate
		{
			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x3D5CE0", Offset = "0x3D42E0", VA = "0x1803D5CE0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x000046AC File Offset: 0x000028AC
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700030B")]
		public uint Channels
		{
			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x4D59A0", Offset = "0x4D3FA0", VA = "0x1804D59A0", Slot = "5")]
		public void Set(ref AudioBuffer other)
		{
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x4D59E0", Offset = "0x4D3FE0", VA = "0x1804D59E0", Slot = "6")]
		public void Set(ref AudioBuffer? other)
		{
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x4D5900", Offset = "0x4D3F00", VA = "0x1804D5900", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x4D5950", Offset = "0x4D3F50", VA = "0x1804D5950", Slot = "4")]
		public void Get(out AudioBuffer output)
		{
		}

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Frames;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x10")]
		private uint m_FramesCount;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x14")]
		private uint m_SampleRate;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x18")]
		private uint m_Channels;
	}
}
