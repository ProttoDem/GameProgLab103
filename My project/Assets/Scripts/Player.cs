using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player
{
    // ����������� �������� ������ ������ ���� �������, ����� �������������
    // �������� ������� ����� �������� new.
    private Player() { }

    // ������ �������� ��������� � ��������� ���� ������. ����������
    // ��������� �������� ���������������� ��� ����, � ��� ��� ����� ������
    // ����������� � ����������. � ���� ������� �� ���������� ���������� ��
    // ���, ����������� �������� �������� ������ ������������� ���������
    // �������� � ������������� �����.
    private static Player _instance;

    // ��� ����������� �����, ����������� �������� � ���������� ��������.
    // ��� ������ �������, �� ������ ��������� �������� � �������� ��� �
    // ����������� ����. ��� ����������� ��������, �� ���������� �������
    // ������, ���������� � ����������� ����.
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
