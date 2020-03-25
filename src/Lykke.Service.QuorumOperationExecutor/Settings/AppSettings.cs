﻿using JetBrains.Annotations;
using Lykke.Sdk.Settings;
using Lykke.Service.QuorumTransactionSigner.Client;

namespace Lykke.Service.QuorumOperationExecutor.Settings
{
    [UsedImplicitly]
    public class AppSettings : BaseAppSettings
    {
        [UsedImplicitly(ImplicitUseKindFlags.Assign)]
        public QuorumOperationExecutorSettings QuorumOperationExecutorService { get; set; }
        
        [UsedImplicitly(ImplicitUseKindFlags.Assign)]
        public QuorumTransactionSignerServiceClientSettings QuorumTransactionSignerService { get; set; }
    }
}
