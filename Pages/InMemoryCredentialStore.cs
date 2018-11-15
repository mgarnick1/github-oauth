namespace AspNetCoreGithubAuth.Pages
{
	internal class InMemoryCredentialStore
	{
		private Credentials credentials;

		public InMemoryCredentialStore(Credentials credentials)
		{
			this.credentials = credentials;
		}
	}
}