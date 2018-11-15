using System.Net.Http.Headers;

namespace AspNetCoreGithubAuth.Pages
{
	internal class GitHubClient
	{
		private ProductHeaderValue productHeaderValue;
		private InMemoryCredentialStore inMemoryCredentialStore;

		public GitHubClient(ProductHeaderValue productHeaderValue, InMemoryCredentialStore inMemoryCredentialStore)
		{
			this.productHeaderValue = productHeaderValue;
			this.inMemoryCredentialStore = inMemoryCredentialStore;
		}

		public object Repository { get; internal set; }
	}
}