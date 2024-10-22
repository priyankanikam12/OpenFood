using Microsoft.AspNetCore.Mvc;
using OpenFood.Models;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;

namespace OpenFood.Controllers
{
    public class VegetableController : Controller
    {
        public IActionResult Index()
        {
            var vegetables = new List<Vegetable>
            {
                new Vegetable
                {
                    Name = "Tomato",
                    ImageUrl = "/image/Tomato_je.jpg",
                    Details = "Tomato is a red vegetable used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=tomato"
                },
                new Vegetable
                {
                    Name = "Potato",
                    ImageUrl = "/image/Patates.jpg",
                    Details = "Potato is a starchy tuber widely grown across India.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=potato"
                },
                new Vegetable
                {
                    Name = "Onion",
                    ImageUrl = "/image/Mixed_onions.jpg",
                    Details = "Onion is a staple ingredient in Indian cooking.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=onion"
                },
                new Vegetable
                {
                    Name = "Ginger",
                    ImageUrl = "/image/Ingwer_2_(fcm).jpg",
                    Details = "Ginger is commonly used in Indian cuisine and medicines.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=ginger"
                },
                new Vegetable
                {
                    Name = "Garlic",
                    ImageUrl = "/image/Garlic_bulbs_and_cloves.jpg",
                    Details = "Garlic is used as a seasoning and in traditional medicine.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=garlic"
                },
                new Vegetable
                {
                    Name = "Carrot",
                    ImageUrl = "/image/Vegetable-Carrot-Bundle-wStalks.jpg",
                    Details = "Carrots are rich in beta-carotene and commonly used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=carrot"
                },
                new Vegetable
                {
                    Name = "Cabbage",
                    ImageUrl = "/image/Cabbage_and_cross_section_on_white.jpg",
                    Details = "Cabbage is used in various Indian dishes and salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=cabbage"
                },
                new Vegetable   
                {
                    Name = "Spinach",
                    ImageUrl = "/image/Spinacia_oleracea_Spinazie_bloeiend.jpg",
                    Details = "Spinach is a nutrient-rich leafy green vegetable.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=spinach"
                },
                new Vegetable     
                {
                    Name = "Brinjal",
                    ImageUrl = "/image/Eleven_long_purple_eggplants.jpg",
                    Details = "Brinjal, or eggplant, is used in various regional recipes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=brinjal"
                },
                new Vegetable
                {
                    Name = "Cauliflower",
                    ImageUrl = "/image/Chou-fleur_02.jpg",
                    Details = "Cauliflower is versatile and can be used in various cuisines.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=cauliflower"
                },
                new Vegetable
                {
                    Name = "Bell Pepper",
                    ImageUrl = "/image/Green-Yellow-Red-Pepper-2009.jpg",
                    Details = "Bell peppers add color and flavor to dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=bell+pepper"
                },
                new Vegetable
                {
                    Name = "Cucumber",
                    ImageUrl = "/image/Cucumber_BNC.jpg",
                    Details = "Cucumber is a refreshing vegetable often used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=cucumber"
                },
                new Vegetable
                {
                    Name = "Radish",
                    ImageUrl = "/image/Raphanus_sativus-1.jpg",
                    Details = "Radishes are crunchy and add a peppery flavor to dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=radish"
                },
                new Vegetable
                {
                    Name = "Green Beans",
                    ImageUrl = "/image/CDC_greenbean.jpg",
                    Details = "Green beans are tender and often stir-fried or steamed.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=green+beans"
                },
                new Vegetable
                {
                    Name = "Peas",
                    ImageUrl = "/image/Peas_in_pods_2016_G1.jpg",
                    Details = "Peas are sweet and often added to various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=peas"
                },
                new Vegetable
                {
                    Name = "Pumpkin",
                    ImageUrl = "/image/Connecticut_Field_cultivar_of_Cucurbita_pepo.jpg",
                    Details = "Pumpkin is used in curries and desserts.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=pumpkin"
                },
                new Vegetable
                {
                    Name = "Sweet Potato",
                    ImageUrl = "/image/Ipomoea_batatas_006.jpeg",
                    Details = "Sweet potatoes are nutritious and sweet, often baked or fried.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=sweet+potato"
                },
                new Vegetable
                {
                    Name = "Methi (Fenugreek)",
                    ImageUrl = "/image/Aesthetic_bunch_of_fenugreek_greens.jpg",
                    Details = "Methi leaves are used in curries and are rich in iron.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=methi"
                },
                new Vegetable
                {
                    Name = "Coriander",
                    ImageUrl = "/image/Koriander_IMG_20220114.jpg",
                    Details = "Coriander is a popular herb used in many Indian dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=coriander"
                },
                new Vegetable
                {
                    Name = "Ladyfinger (Okra)",
                    ImageUrl = "/image/Hong_Kong_Okra_Aug_25_2012.jpeg",
                    Details = "Ladyfinger is often fried or used in curries.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=ladyfinger"
                },
                new Vegetable
                {
                    Name = "Bottle Gourd",
                    ImageUrl = "/image/Bottle Gourd.jpg",
                    Details = "Bottle gourd is a nutritious vegetable used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=bottle+gourd"
                },
                new Vegetable
                {
                    Name = "Drumstick",
                    ImageUrl = "/image/Drumstick.jpeg",
                    Details = "Drumstick is often used in sambar and other curries.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=drumstick"
                },
                new Vegetable
                {
                    Name = "Taro Root",
                    ImageUrl = "/image/taroroot.jpg",
                    Details = "Taro root is a starchy tuber commonly used in Indian cooking.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=taro+root"
                },
                new Vegetable
                {
                    Name = "Radicchio",
                    ImageUrl = "/image/Radicchio.jpeg",
                    Details = "Radicchio is a leafy vegetable with a slightly bitter taste.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=radicchio"
                },
                new Vegetable
                {
                    Name = "Artichoke",
                    ImageUrl = "/image/Artichoke_J1.jpg",
                    Details = "Artichokes are unique vegetables often used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=artichoke"
                },
                new Vegetable
                {
                    Name = "Zucchini",
                    ImageUrl = "/image/Courgette_J1.jpeg",
                    Details = "Zucchini is a summer squash used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=zucchini"
                },
                new Vegetable
                {
                    Name = "Leeks",
                    ImageUrl = "/image/LeeksSupermarket.jpg",
                    Details = "Leeks have a mild onion flavor and are used in soups and salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=leeks"
                },
                new Vegetable
                {
                    Name = "Chinese Cabbage",
                    ImageUrl = "/image/ChineseCabbage.jpg",
                    Details = "Chinese cabbage is used in stir-fries and salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=chinese+cabbage"
                },
                new Vegetable
                {
                    Name = "Nasturtium",
                    ImageUrl = "/image/Nasturtium_--_Tropaeolum.jpg",
                    Details = "Nasturtium leaves and flowers are edible and used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=nasturtium"
                },
                new Vegetable
                {
                    Name = "Purslane",
                    ImageUrl = "/image/Portulaca_sativa_01.jpg",
                    Details = "Purslane is a leafy vegetable with a slightly sour flavor.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=purslane"
                },
                new Vegetable
                {
                    Name = "Chayote",
                    ImageUrl = "/image/Chayote_cross_section_BNC.jpg",
                    Details = "Chayote is a green vegetable often used in salads and stir-fries.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=chayote"
                },
                new Vegetable
                {
                    Name = "Kohlrabi",
                    ImageUrl = "/image/KohlrabiinMarket.jpg",
                    Details = "Kohlrabi has a mild flavor and is often used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=kohlrabi"
                },
                new Vegetable
                {
                    Name = "Sunchoke (Jerusalem Artichoke)",
                    ImageUrl = "/image/Sunchoke (Jerusalem Artichoke).jpg",
                    Details = "Sunchokes are tubers with a nutty flavor, used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=sunchoke"
                }
            };

            return View(vegetables);
        }

        // GET: /Vegetable/Buy?vegetableName={name}
        public IActionResult Buy(string vegetableName)
        {
            var vegetable = GetVegetableByName(vegetableName); // Fetch vegetable data
            if (vegetable == null)
            {
                return NotFound(); // Return 404 if not found
            }

            var buyingOptions = new List<BuyingOption>
            {
                new BuyingOption { PlatformName = "BigBasket", Url = "https://www.bigbasket.com/cl/fruits-vegetables/" },
                new BuyingOption { PlatformName = "Vegease", Url = "https://vegease.in/" },
                new BuyingOption { PlatformName = "StarQuik", Url = "https://www.starquik.com/" },
                new BuyingOption { PlatformName = "The Vegetable Bazaar", Url = "https://thevegetablebazaar.in/" },
                new BuyingOption { PlatformName = "FarmersFZ", Url = "https://farmersfz.com/" },
                new BuyingOption { PlatformName = "SabziKart", Url = "https://www.sabzikart.com/" },
            };

            var viewModel = new BuyVegetableViewModel
            {
                Vegetable = vegetable,
                BuyingOptions = buyingOptions
            };

            return View(viewModel);
        }

        // Helper method to get vegetable by name
        private Vegetable GetVegetableByName(string name)
        {
            var allVegetables = new List<Vegetable>
            {
                 new Vegetable
                {
                    Name = "Tomato",
                    ImageUrl = "/image/Tomato_je.jpg",
                    Details = "Tomato is a red vegetable used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=tomato"
                },
                new Vegetable
                {
                    Name = "Potato",
                    ImageUrl = "/image/Patates.jpg",
                    Details = "Potato is a starchy tuber widely grown across India.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=potato"
                },
                new Vegetable
                {
                    Name = "Onion",
                    ImageUrl = "/image/Mixed_onions.jpg",
                    Details = "Onion is a staple ingredient in Indian cooking.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=onion"
                },
                new Vegetable
                {
                    Name = "Ginger",
                    ImageUrl = "/image/Ingwer_2_(fcm).jpg",
                    Details = "Ginger is commonly used in Indian cuisine and medicines.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=ginger"
                },
                new Vegetable
                {
                    Name = "Garlic",
                    ImageUrl = "/image/Garlic_bulbs_and_cloves.jpg",
                    Details = "Garlic is used as a seasoning and in traditional medicine.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=garlic"
                },
                new Vegetable
                {
                    Name = "Carrot",
                    ImageUrl = "/image/Vegetable-Carrot-Bundle-wStalks.jpg",
                    Details = "Carrots are rich in beta-carotene and commonly used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=carrot"
                },
                new Vegetable
                {
                    Name = "Cabbage",
                    ImageUrl = "/image/Cabbage_and_cross_section_on_white.jpg",
                    Details = "Cabbage is used in various Indian dishes and salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=cabbage"
                },
                new Vegetable
                {
                    Name = "Spinach",
                    ImageUrl = "/image/Spinacia_oleracea_Spinazie_bloeiend.jpg",
                    Details = "Spinach is a nutrient-rich leafy green vegetable.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=spinach"
                },
                new Vegetable
                {
                    Name = "Brinjal",
                    ImageUrl = "/image/Eleven_long_purple_eggplants.jpg",
                    Details = "Brinjal, or eggplant, is used in various regional recipes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=brinjal"
                },
                new Vegetable
                {
                    Name = "Cauliflower",
                    ImageUrl = "/image/Chou-fleur_02.jpg",
                    Details = "Cauliflower is versatile and can be used in various cuisines.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=cauliflower"
                },
                new Vegetable
                {
                    Name = "Bell Pepper",
                    ImageUrl = "/image/Green-Yellow-Red-Pepper-2009.jpg",
                    Details = "Bell peppers add color and flavor to dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=bell+pepper"
                },
                new Vegetable
                {
                    Name = "Cucumber",
                    ImageUrl = "/image/Cucumber_BNC.jpg",
                    Details = "Cucumber is a refreshing vegetable often used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=cucumber"
                },
                new Vegetable
                {
                    Name = "Radish",
                    ImageUrl = "/image/Raphanus_sativus-1.jpg",
                    Details = "Radishes are crunchy and add a peppery flavor to dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=radish"
                },
                new Vegetable
                {
                    Name = "Green Beans",
                    ImageUrl = "/image/CDC_greenbean.jpg",
                    Details = "Green beans are tender and often stir-fried or steamed.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=green+beans"
                },
                new Vegetable
                {
                    Name = "Peas",
                    ImageUrl = "/image/Peas_in_pods_2016_G1.jpg",
                    Details = "Peas are sweet and often added to various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=peas"
                },
                new Vegetable
                {
                    Name = "Pumpkin",
                    ImageUrl = "/image/Connecticut_Field_cultivar_of_Cucurbita_pepo.jpg",
                    Details = "Pumpkin is used in curries and desserts.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=pumpkin"
                },
                new Vegetable
                {
                    Name = "Sweet Potato",
                    ImageUrl = "/image/Ipomoea_batatas_006.jpeg",
                    Details = "Sweet potatoes are nutritious and sweet, often baked or fried.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=sweet+potato"
                },
                new Vegetable
                {
                    Name = "Methi (Fenugreek)",
                    ImageUrl = "/image/Aesthetic_bunch_of_fenugreek_greens.jpg",
                    Details = "Methi leaves are used in curries and are rich in iron.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=methi"
                },
                new Vegetable
                {
                    Name = "Coriander",
                    ImageUrl = "/image/Koriander_IMG_20220114.jpg",
                    Details = "Coriander is a popular herb used in many Indian dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=coriander"
                },
                new Vegetable
                {
                    Name = "Ladyfinger (Okra)",
                    ImageUrl = "/image/Hong_Kong_Okra_Aug_25_2012.jpeg",
                    Details = "Ladyfinger is often fried or used in curries.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=ladyfinger"
                },
                new Vegetable
                {
                    Name = "Bottle Gourd",
                    ImageUrl = "/image/Bottle Gourd.jpg",
                    Details = "Bottle gourd is a nutritious vegetable used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=bottle+gourd"
                },
                new Vegetable
                {
                    Name = "Drumstick",
                    ImageUrl = "/image/Drumstick.jpeg",
                    Details = "Drumstick is often used in sambar and other curries.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=drumstick"
                },
                new Vegetable
                {
                    Name = "Taro Root",
                    ImageUrl = "/image/taroroot.jpg",
                    Details = "Taro root is a starchy tuber commonly used in Indian cooking.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=taro+root"
                },
                new Vegetable
                {
                    Name = "Radicchio",
                    ImageUrl = "/image/Radicchio.jpeg",
                    Details = "Radicchio is a leafy vegetable with a slightly bitter taste.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=radicchio"
                },
                new Vegetable
                {
                    Name = "Artichoke",
                    ImageUrl = "/image/Artichoke_J1.jpg",
                    Details = "Artichokes are unique vegetables often used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=artichoke"
                },
                new Vegetable
                {
                    Name = "Zucchini",
                    ImageUrl = "/image/Courgette_J1.jpeg",
                    Details = "Zucchini is a summer squash used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=zucchini"
                },
                new Vegetable
                {
                    Name = "Leeks",
                    ImageUrl = "/image/LeeksSupermarket.jpg",
                    Details = "Leeks have a mild onion flavor and are used in soups and salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=leeks"
                },
                new Vegetable
                {
                    Name = "Chinese Cabbage",
                    ImageUrl = "/image/ChineseCabbage.jpg",
                    Details = "Chinese cabbage is used in stir-fries and salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=chinese+cabbage"
                },
                new Vegetable
                {
                    Name = "Nasturtium",
                    ImageUrl = "/image/Nasturtium_--_Tropaeolum.jpg",
                    Details = "Nasturtium leaves and flowers are edible and used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=nasturtium"
                },
                new Vegetable
                {
                    Name = "Purslane",
                    ImageUrl = "/image/Portulaca_sativa_01.jpg",
                    Details = "Purslane is a leafy vegetable with a slightly sour flavor.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=purslane"
                },
                new Vegetable
                {
                    Name = "Chayote",
                    ImageUrl = "/image/Chayote_cross_section_BNC.jpg",
                    Details = "Chayote is a green vegetable often used in salads and stir-fries.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=chayote"
                },
                new Vegetable
                {
                    Name = "Kohlrabi",
                    ImageUrl = "/image/KohlrabiinMarket.jpg",
                    Details = "Kohlrabi has a mild flavor and is often used in salads.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=kohlrabi"
                },
                new Vegetable
                {
                    Name = "Sunchoke (Jerusalem Artichoke)",
                    ImageUrl = "/image/Sunchoke (Jerusalem Artichoke).jpg",
                    Details = "Sunchokes are tubers with a nutty flavor, used in various dishes.",
                    Region = "India",
                    BuyLink = "https://www.example.com/search?q=sunchoke"
                }
            };
            return allVegetables.Find(v => v.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
