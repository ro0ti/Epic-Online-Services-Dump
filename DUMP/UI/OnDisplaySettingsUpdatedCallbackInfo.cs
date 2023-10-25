using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public struct OnDisplaySettingsUpdatedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A2")]
		public object ClientData
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A3")]
		public bool IsVisible
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x4AB000", Offset = "0x4A9600", VA = "0x1804AB000")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x4AB020", Offset = "0x4A9620", VA = "0x1804AB020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000029B4 File Offset: 0x00000BB4
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A4")]
		public bool IsExclusiveInput
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x4AAFF0", Offset = "0x4A95F0", VA = "0x1804AAFF0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x4AB010", Offset = "0x4A9610", VA = "0x1804AB010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4AAFA0", Offset = "0x4A95A0", VA = "0x1804AAFA0")]
		internal void Set(ref OnDisplaySettingsUpdatedCallbackInfoInternal other)
		{
		}
	}
}
