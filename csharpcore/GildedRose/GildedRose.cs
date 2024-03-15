using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;

    public GildedRose(IList<Item> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            DailyUpdate(item);
        }
    }

    private void DailyUpdate(Item item)
    {
        var isBackstoagePassesItem = item.Name == "Backstage passes to a TAFKAL80ETC concert";

        var isLegendaryItem = item.Name == "Sulfuras, Hand of Ragnaros";
        
        if (isBackstoagePassesItem)
        {
            if (isLegendaryItem)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            
                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            
                item.SellIn = item.SellIn - 1;
               
                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
            }
        }
        else
        {
            if (item.Name != "Aged Brie")
            {
                if (item.Quality > 0)
                {
                    if (!isLegendaryItem)
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }

            if (!isLegendaryItem)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Quality > 0)
                    {
                        if (!isLegendaryItem)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }
}