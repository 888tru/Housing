@echo off
REM ТЕСТОВЫЙ СКРИПТ ДЛЯ ПРОВЕРКИ ВСЕХ КОМАНД

setlocal enabledelayedexpansion

set "appPath=C:\Users\user\source\repos\Housing\Housing\bin\Release\net10.0\Housing.exe"

echo.
echo ╔════════════════════════════════════════════════════════════════╗
echo ║  ТЕСТИРОВАНИЕ ПРИЛОЖЕНИЯ HOUSING MANAGEMENT                   ║
echo ╚════════════════════════════════════════════════════════════════╝
echo.

echo Т1: Проверка запуска приложения
echo ════════════════════════════════════
echo Команда: /help затем /exit
echo.

(
  echo /help
  echo /exit
) | !appPath! > test_output.txt 2>&1

if !ERRORLEVEL! equ 0 (
  echo ✅ Приложение запустилось успешно
  type test_output.txt | find "УПРАВЛЕНИЕ" >nul
  if !ERRORLEVEL! equ 0 (
	echo ✅ Список команд отображается корректно
  ) else (
	echo ❌ Список команд не найден
  )
) else (
  echo ❌ Ошибка запуска приложения
)

echo.
echo Т2: Проверка новых команд в списке
echo ══════════════════════════════════════
type test_output.txt | find "/deleteAll" >nul
if !ERRORLEVEL! equ 0 (
  echo ✅ Команда /deleteAll найдена
) else (
  echo ❌ Команда /deleteAll НЕ найдена
)

type test_output.txt | find "/deleteType" >nul
if !ERRORLEVEL! equ 0 (
  echo ✅ Команда /deleteType найдена
) else (
  echo ❌ Команда /deleteType НЕ найдена
)

echo.
echo Т3: Проверка справки (/help)
echo ═══════════════════════════════
(
  echo /help
  echo /exit
) | !appPath! > test_help.txt 2>&1

type test_help.txt | find "СПРАВКА" >nul
if !ERRORLEVEL! equ 0 (
  echo ✅ Справка отображается
) else (
  echo ❌ Справка не найдена
)

type test_help.txt | find "/deleteAll" >nul
if !ERRORLEVEL! equ 0 (
  echo ✅ /deleteAll задокументирована в справке
) else (
  echo ❌ /deleteAll не задокументирована
)

type test_help.txt | find "/deleteType" >nul
if !ERRORLEVEL! equ 0 (
  echo ✅ /deleteType задокументирована в справке
) else (
  echo ❌ /deleteType не задокументирована
)

echo.
echo Т4: Проверка обработки некорректной команды
echo ═════════════════════════════════════════════
(
  echo /invalidcommand
  echo /exit
) | !appPath! > test_invalid.txt 2>&1

type test_invalid.txt | find "correct" >nul
if !ERRORLEVEL! equ 0 (
  echo ✅ Некорректная команда обработана правильно
) else (
  echo ⚠️ Проверьте обработку ошибочных команд
)

echo.
echo ╔════════════════════════════════════════════════════════════════╗
echo ║  ИТОГИ ТЕСТИРОВАНИЯ                                           ║
echo ╚════════════════════════════════════════════════════════════════╝
echo.
echo 🎉 ТЕСТИРОВАНИЕ ЗАВЕРШЕНО!
echo.
echo 📋 Проверьте результаты выше.
echo.

del test_output.txt test_help.txt test_invalid.txt >nul 2>&1

pause
