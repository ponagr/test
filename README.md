Början på ett bibliotekssystem.

Svara på följande frågor:
1. Vad gör kommandot git add?
    Lägger till ändringar i "staging area", som då är redo att commitas
2. Vad är staging area?
    Ett mellanläge, där man lägger till och samlar de filer man vill commita 
3. Vad gör kommandot git commit? Vad är en commit?
    Man commitar filerna som ligger i "staging area", alltså sparar ändringarna till .git versions-historik
4. Vad gör kommandot git status?
    Kollar status på filerna, om något har ändrats i en fil sedan förra commiten, visar om filer ligger i staging area osv
5. Vad gör kommandot git diff?
    Visar ändringar mellan nuvarande fil och tidigare commitad fil, jämför och visar tydligt vad som har tagits bort eller lagts till och på vilken rad.
6. Vad gör kommandot git log?
    Visar historiken på tidigare commits, med datum och kommentar
7. Vad är skillnaden på Git och Github?
    Git är ett versionshanterings-system, GitHub är en av flera "remotes" alltså servrar där man kan ladda upp sin lokala git-repo,
    så att tillgången finns tillgänglig för andra enheter.
8. Vad finns det för alternativ till Github?
    GitLabs, SourceHut och många fler, GitHub är den största och mest använda
9. Vad gör kommandot push?
    Laddar upp det lokala git-repot till en remote-server
10. Vad är skillnaden på commit och push?
    commit sparar ändringarna lokalt, push tar det som du har sparat lokalt och laddar upp det till en remote-server
11. Har push något med Github att göra? Isf hur?
    Nej inte direkt, du kan pusha till andra ställen med, allt du behöver är en länk till en server för att veta vart du ska pusha.
12. Nu när du kan svara på allt detta fundera över;
- vad ska git vara bra för?
    Lättare sammarbete vid större projekt och företag, säkerhet vid ändring av kod, kan gå tillbaka och se när ett program fungerade och gå igenom vad som ändrats sedan dess.
- varför används det i princip uteslutande som versionshanteringssystem i världen över?
    Öppen källkod, gratis, snabb och effektiv, god säkerhet, stöd för flera operativsystem och IDEs
- hur kan du själv använda dig av git i dina projekt och dina studier?
    Kunna söka hjälp i forum genom att dela min kod via t.ex GitHub,
    Tidigare har jag också skapat flera projekt och kopierat över fungerande kod innan jag börjar prova mig fram med ny kod
    så att jag vet att jag har en tidigare fungerande version att återgå till om något skulle bli helt fel eller förvirrande.
    Detta går nu att göra med git istället, mindre krångel, man kan fortsätta arbeta och istället commita med ett meddelande att denna version fungerar som tänkt.
    Sedan kan man gå in och jämföra den versionen med nuvarande version och se vilka skillnader det finns och lättare se vad som gått fel.
- finns det nåt annat du kan använda git till än dina programmeringsprojekt?
    Ja, mycket annat, böcker, artiklar, dokumentation, grafisk design och mycket mer där man kan behöva samarbeta med andra eller hantera olika versioner som man vill uppdatera