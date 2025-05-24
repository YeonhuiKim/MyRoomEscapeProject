using UnityEngine;
using System;

[Serializable]
public class Item
{
    public enum Type{
        Cube,
        Ball,
    }

    public Type type;       // ������ ����
    public Sprite sprite;   // ���Կ� ǥ�õǴ� �̹���

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
