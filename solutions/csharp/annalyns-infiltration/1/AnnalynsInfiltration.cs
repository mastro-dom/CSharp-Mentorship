static class QuestLogic
{
    // A fast attack can be made if the knight is sleeping.
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    // The group can be spied upon if at least one of them is awake.
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    // The prisoner can be signalled if the prisoner is awake and the archer is sleeping.
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return prisonerIsAwake && !archerIsAwake;
    }

    // The prisoner can be freed:
    // - If the dog is present: archer must be asleep
    // - If the dog is not present: prisoner must be awake and both kidnappers must be asleep
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool canFreeWithDog = petDogIsPresent && !archerIsAwake;
        bool canFreeWithoutDog = !petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake;

        return canFreeWithDog || canFreeWithoutDog;
    }
}
