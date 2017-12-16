﻿using VaultSharp.Backends.Auth;
using VaultSharp.Backends.Secret;
using VaultSharp.Backends.System;

namespace VaultSharp.V1
{
    public interface IVaultClientV1
    {
        ISecretBackend Secret { get; }

        IAuthBackend Auth { get; }

        ISystemBackend System { get; }
    }
}