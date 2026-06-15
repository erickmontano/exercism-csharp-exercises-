static class QuestLogic
{
    // When the knight is asleep, Annalyn can make a fast attack!
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    // Annalyn can spy on someone if at least one of them is awake.
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    // Annalyn can signal the prisoner if the archer is asleep and the prisoner is awake.
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => prisonerIsAwake && !archerIsAwake;

    // Annalyn can free the prisoner if the prisoner is awake and (the knight and archer are asleep or she has her pet dog with her).
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => 
        (!archerIsAwake && petDogIsPresent) || (prisonerIsAwake && !knightIsAwake && !archerIsAwake && !petDogIsPresent);
}
