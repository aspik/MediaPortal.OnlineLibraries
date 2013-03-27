﻿#region Copyright (C) 2007-2013 Team MediaPortal

/*
    Copyright (C) 2007-2013 Team MediaPortal
    http://www.team-mediaportal.com

    This file is part of MediaPortal 2

    MediaPortal 2 is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    MediaPortal 2 is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MediaPortal 2. If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MediaPortal.OnlineLibraries.TheMovieDb.Data
{
  //{
  //  "aspect_ratio": 1.78,
  //  "file_path": "/mOTtuakUTb1qY6jG6lzMfjdhLwc.jpg",
  //  "height": 1080,
  //  "iso_639_1": null,
  //  "width": 1920
  //}
  [DataContract]
  public class ImageCollection
  {
    [DataMember(Name = "id")]
    public int Id { get; set; }

    [DataMember(Name = "backdrops")]
    public List<MovieImage> Backdrops { get; set; }

    [DataMember(Name = "covers")]
    public List<MovieImage> Covers { get; set; }

    [DataMember(Name = "posters")]
    public List<MovieImage> Posters { get; set; }

    public void SetMovieIds()
    {
      if (Covers != null) Covers.ForEach(c => c.MovieId = Id);
      if (Backdrops != null) Backdrops.ForEach(c => c.MovieId = Id);
      if (Posters != null) Posters.ForEach(c => c.MovieId = Id);
    }
  }
}