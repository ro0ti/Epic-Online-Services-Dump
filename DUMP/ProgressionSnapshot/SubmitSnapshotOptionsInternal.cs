using System;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	internal struct SubmitSnapshotOptionsInternal : ISettable<SubmitSnapshotOptions>, IDisposable
	{
		// Token: 0x170004D4 RID: 1236
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004D4")]
		public uint SnapshotId
		{
			[Token(Token = "0x600127C")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SubmitSnapshotOptions other)
		{
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x503D00", Offset = "0x502300", VA = "0x180503D00", Slot = "5")]
		public void Set(ref SubmitSnapshotOptions? other)
		{
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x4")]
		private uint m_SnapshotId;
	}
}
