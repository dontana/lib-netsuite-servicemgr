﻿using System;

namespace SuiteTalk
{
    public interface ISearchRow
    {
        SearchRowBasic GetBasic();

        SearchRowBasic CreateBasic();

        SearchRowBasic GetJoin(string joinName);

        SearchRowBasic CreateJoin(string joinName);
    }

    public interface ISearchRow<T> where T : SearchRowBasic
    {
        T GetBasic();

        T CreateBasic();

        ISearchRow<T> CreateBasic(Action<T> initializer);

        J GetJoin<J>(string joinName) where J : SearchRowBasic;

        J CreateJoin<J>(string joinName) where J : SearchRowBasic;

        ISearchRow<T> CreateJoin<J>(string joinName, Action<J> initializer) where J : SearchRowBasic;
    }

    partial interface ISupportsCustomSearchJoin
    {
        CustomSearchRowBasic[] GetCustomSearchJoin();

        CustomSearchRowBasic[] CreateCustomSearchJoin();
    }
}
