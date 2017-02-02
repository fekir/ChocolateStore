namespace ChocolateStore
{
    class Arguments
    {
		// where the packages are saved and referenced
        public string Directory { get; set; }
		//where to download the package from
        public string Url { get; set; }
		// where to save the packages
		public string CacheDir { get; set; }
    }
}
