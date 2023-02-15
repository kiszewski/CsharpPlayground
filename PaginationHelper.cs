using System;
using System.Collections.Generic;

public class PagnationHelper<T>
{
    private IList<T> _collection;
    private int _itemsPerPage;

    public PagnationHelper(IList<T> collection, int itemsPerPage)
    {
        _collection = collection;
        _itemsPerPage = itemsPerPage;
    }

    public int ItemCount
    {
        get { return _collection.Count; }
    }

    public int PageCount
    {
        get
        {
            var rest = ItemCount % _itemsPerPage;
            var division = ItemCount / _itemsPerPage;

            return rest > 0 ? (division + 1) : division;
        }
    }

    public int PageItemCount(int pageIndex)
    {
        if (pageIndex < 0) return -1;

        var index = pageIndex + 1;

        var chunks = _collection.Chunk(_itemsPerPage).ToList();

        return chunks.Count() >= index ? chunks[pageIndex].Count() : -1;
    }

    public int PageIndex(int itemIndex)
    {
        if (itemIndex < 0 || itemIndex > ItemCount)
        {
            return -1;
        }

        var res = itemIndex / _itemsPerPage;

        return res;
    }
}