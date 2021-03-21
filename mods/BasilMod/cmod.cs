

if (!isObject(BasilModAutoloader))
{
    new ScriptObject(BasilModAutoloader)
    {
    };
}package BasilModAutoloader {
  function BasilModAutoloader::setup() {
    LiFx::registerCallback($LiFx::hooks::onInitialized, loadBasil, BasilModAutoloader);
  }
  function BasilModAutoloader::loadBasil() {
    exec("basilmodloader/loader.cs");
  }

};
activatePackage(BasilModAutoloader);
LiFx::registerCallback($LiFx::hooks::mods, setup, BasilModAutoloader);
