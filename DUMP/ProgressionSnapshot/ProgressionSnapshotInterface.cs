using System;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	public sealed class ProgressionSnapshotInterface : Handle
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public ProgressionSnapshotInterface()
		{
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public ProgressionSnapshotInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x4FCB70", Offset = "0x4FB170", VA = "0x1804FCB70")]
		public Result AddProgression(ref AddProgressionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x4FCC10", Offset = "0x4FB210", VA = "0x1804FCC10")]
		public Result BeginSnapshot(ref BeginSnapshotOptions options, out uint outSnapshotId)
		{
			return Result.Success;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x4FCD10", Offset = "0x4FB310", VA = "0x1804FCD10")]
		public void DeleteSnapshot(ref DeleteSnapshotOptions options, object clientData, OnDeleteSnapshotCallback completionDelegate)
		{
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x4FCF10", Offset = "0x4FB510", VA = "0x1804FCF10")]
		public Result EndSnapshot(ref EndSnapshotOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001264")]
		[Address(RVA = "0x4FD0E0", Offset = "0x4FB6E0", VA = "0x1804FD0E0")]
		public void SubmitSnapshot(ref SubmitSnapshotOptions options, object clientData, OnSubmitSnapshotCallback completionDelegate)
		{
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x4FCFA0", Offset = "0x4FB5A0", VA = "0x1804FCFA0")]
		[MonoPInvokeCallback(typeof(OnDeleteSnapshotCallbackInternal))]
		internal static void OnDeleteSnapshotCallbackInternalImplementation(ref DeleteSnapshotCallbackInfoInternal data)
		{
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x4FD040", Offset = "0x4FB640", VA = "0x1804FD040")]
		[MonoPInvokeCallback(typeof(OnSubmitSnapshotCallbackInternal))]
		internal static void OnSubmitSnapshotCallbackInternalImplementation(ref SubmitSnapshotCallbackInfoInternal data)
		{
		}

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		public const int AddprogressionApiLatest = 1;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		public const int BeginsnapshotApiLatest = 1;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		public const int DeletesnapshotApiLatest = 1;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		public const int EndsnapshotApiLatest = 1;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		public const int InvalidProgressionsnapshotid = 0;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		public const int SubmitsnapshotApiLatest = 1;
	}
}
