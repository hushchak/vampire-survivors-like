using System.Collections.Generic;
using UnityEngine;

public static class SaveManager
{
    public enum Slot { Slot1 = 1, Slot2 = 2, Slot3 = 3 }

    private static Dictionary<Slot, FileStorage<GameData>> slotStorages;
    private static FileStorage<PreferencesData> preferencesStorage;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        slotStorages = new Dictionary<Slot, FileStorage<GameData>>
        {
            { Slot.Slot1, CreateSlotStorage(Slot.Slot1) },
            { Slot.Slot2, CreateSlotStorage(Slot.Slot2) },
            { Slot.Slot3, CreateSlotStorage(Slot.Slot3) },
        };

        preferencesStorage = new FileStorage<PreferencesData>(
            GetPath("Preferences", "preferences.json"),
            () => new PreferencesData()
        );
    }

    public static GameData GetSlotData(Slot slot) =>
        slotStorages.TryGetValue(slot, out var s)
            ? s.Read()
            : null;

    public static void SetSlotData(Slot slot, GameData data)
    {
        if (slotStorages.TryGetValue(slot, out var s))
        {
            s.Write(data);
        }
    }

    public static PreferencesData GetPreferencesData() =>
        preferencesStorage.Read();

    private static FileStorage<GameData> CreateSlotStorage(Slot slot) =>
        new FileStorage<GameData>(
            GetPath("DataSlots", slot.ToString()),
            () => new GameData()
        );

    private static string GetPath(string folder, string file) =>
        System.IO.Path.Combine(Application.persistentDataPath, folder, file);
}
