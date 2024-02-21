var ghPages = require("gh-pages");

var packageUrl = "https://github.com/EverybodyKurts/Feliz.Plotly.git";

console.log("Publishing to ", packageUrl);

ghPages.publish("./dist", {
    repo: packageUrl
}, function (e) {
    if (e === undefined) {
        console.log("Finished publishing succesfully");
    } else {
        console.log("Error occured while publishing :(", e);
    }
});