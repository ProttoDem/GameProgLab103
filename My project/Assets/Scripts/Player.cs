using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player
{
    // Конструктор Одиночки всегда должен быть скрытым, чтобы предотвратить
    // создание объекта через оператор new.
    private Player() { }

    // Объект одиночки храниться в статичном поле класса. Существует
    // несколько способов инициализировать это поле, и все они имеют разные
    // достоинства и недостатки. В этом примере мы рассмотрим простейший из
    // них, недостатком которого является полная неспособность правильно
    // работать в многопоточной среде.
    private static Player _instance;

    // Это статический метод, управляющий доступом к экземпляру одиночки.
    // При первом запуске, он создаёт экземпляр одиночки и помещает его в
    // статическое поле. При последующих запусках, он возвращает клиенту
    // объект, хранящийся в статическом поле.
    public static Player GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Player();
        }
        return _instance;
    }

    public float Speed { get; } = 8f;

    public float JumpingPower { get; } = 16f;
}
