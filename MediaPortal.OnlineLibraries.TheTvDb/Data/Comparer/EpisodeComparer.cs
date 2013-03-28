using System.Collections.Generic;

namespace MediaPortal.OnlineLibraries.TheTvDb.Data.Comparer
{
  /// <summary>
  /// Compare episodes according to their default episode numbers (aired)
  /// </summary>
  internal class EpisodeComparerAired : IComparer<TvdbEpisode>
  {
    #region IComparer<TvdbEpisode> Members

    public int Compare(TvdbEpisode x, TvdbEpisode y)
    {
      return x.EpisodeNumber - y.EpisodeNumber;
    }

    #endregion
  }

  /// <summary>
  /// Compare episodes according to their dvd episode number
  /// </summary>
  internal class EpisodeComparerDvd : IComparer<TvdbEpisode>
  {
    #region IComparer<TvdbEpisode> Members

    public int Compare(TvdbEpisode x, TvdbEpisode y)
    {
      return (int) (x.DvdEpisodeNumber - y.DvdEpisodeNumber);
    }

    #endregion
  }

  /// <summary>
  /// Compare episodes according to their absolute episode number
  /// </summary>
  internal class EpisodeComparerAbsolute : IComparer<TvdbEpisode>
  {
    #region IComparer<TvdbEpisode> Members

    public int Compare(TvdbEpisode x, TvdbEpisode y)
    {
      return x.AbsoluteNumber - y.AbsoluteNumber;
    }

    #endregion
  }
}