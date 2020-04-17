using Attest.Testing.Contracts;

namespace LogoFX.Client.Testing.EndToEnd.FlaUI
{
    /// <inheritdoc />
    public sealed class TeardownService : ITeardownService
    {
        /// <inheritdoc />
        public void Teardown()
        {
            ApplicationContext.Application?.Kill();
        }
    }
}