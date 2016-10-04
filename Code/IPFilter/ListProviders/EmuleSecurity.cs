namespace IPFilter.ListProviders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Models;

    public class EmuleSecurity : IMirrorProvider
    {
        static readonly IEnumerable<FileMirror> mirrors = new[] { new FileMirror("ipfilter.zip", "Emule Security"),
        new FileMirror("fakeservers.txt", "Fake servers list (part one)"),
        new FileMirror("Inclusions.txt", "Fake servers list (part two)") };

        /// <summary>
        /// Gets a list of mirrors for this provider
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FileMirror> GetMirrors()
        {
            return mirrors;
        }

        /// <summary>
        /// The name of the mirror provider
        /// </summary>
        public string Name { get { return "Emule Security"; } }

        public string GetUrlForMirror(FileMirror mirror)
        {
            return string.Format(CultureInfo.CurrentCulture, "http://upd.emule-security.org/{0}", mirror.Id);
        }
    }
}