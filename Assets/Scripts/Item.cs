using UnityEngine;
using System;

[Serializable]
public class Item
{
    public enum Type{
        Cube,
        Ball,
    }

    public Type type;       // 아이템 종류
    public Sprite sprite;   // 슬롯에 표시되는 이미지
}
