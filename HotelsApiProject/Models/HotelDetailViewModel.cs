namespace HotelsApiProject.Models
{
    public class HotelDetailViewModel
    {

        public class Rootobject
        {
            public Data data { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
        }

        public class Data
        {
            public string hotel_name { get; set; }
            public string city { get; set; }
            public string address { get; set; }
            public Composite_Price_Breakdown composite_price_breakdown { get; set; }
            public Breakfast_Review_Score breakfast_review_score { get; set; }
            public Rooms rooms { get; set; }
            public Facilities_Block facilities_block { get; set; }
        }

        public class Composite_Price_Breakdown
        {
            public int has_long_stays_monthly_rate_price { get; set; }
            public Excluded_Amount excluded_amount { get; set; }
            public Gross_Amount_Per_Night gross_amount_per_night { get; set; }
            public Included_Taxes_And_Charges_Amount included_taxes_and_charges_amount { get; set; }
            public All_Inclusive_Amount all_inclusive_amount { get; set; }
            public Gross_Amount_Hotel_Currency gross_amount_hotel_currency { get; set; }
            public All_Inclusive_Amount_Hotel_Currency all_inclusive_amount_hotel_currency { get; set; }
            public Gross_Amount gross_amount { get; set; }
            public object[] benefits { get; set; }
            public Net_Amount net_amount { get; set; }
            public int has_long_stays_weekly_rate_price { get; set; }
            public Price_Display_Config[] price_display_config { get; set; }
            public Charges_Details charges_details { get; set; }
            public Item[] items { get; set; }
        }

        public class Excluded_Amount
        {
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Gross_Amount_Per_Night
        {
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount
        {
            public decimal value { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class All_Inclusive_Amount
        {
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Gross_Amount_Hotel_Currency
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public decimal value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class All_Inclusive_Amount_Hotel_Currency
        {
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Gross_Amount
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public decimal value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Net_Amount
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
        }

        public class Charges_Details
        {
            public string mode { get; set; }
            public string translated_copy { get; set; }
            public Amount amount { get; set; }
        }

        public class Amount
        {
            public string currency { get; set; }
            public int value { get; set; }
        }

        public class Price_Display_Config
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class Item
        {
            public string inclusion_type { get; set; }
            public string kind { get; set; }
            public Item_Amount item_amount { get; set; }
            public Base _base { get; set; }
            public string details { get; set; }
            public string name { get; set; }
        }

        public class Item_Amount
        {
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Base
        {
            public int percentage { get; set; }
            public string kind { get; set; }
        }

        public class Languages_Spoken
        {
            public string[] languagecode { get; set; }
        }

        public class Aggregated_Data
        {
            public int has_kitchen { get; set; }
            public int has_refundable { get; set; }
            public int has_seating { get; set; }
            public Common_Kitchen_Fac[] common_kitchen_fac { get; set; }
            public int has_nonrefundable { get; set; }
        }

        public class Common_Kitchen_Fac
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Only_X_Left
        {
            public Microfunnel_Rooms_List microfunnel_rooms_list { get; set; }
            public Post_Select post_select { get; set; }
            public Microfunnel_Rate_Selection microfunnel_rate_selection { get; set; }
            public Room_Page room_page { get; set; }
            public Rooms_List rooms_list { get; set; }
        }

        public class Microfunnel_Rooms_List
        {
            public string _1070287101 { get; set; }
        }

        public class Post_Select
        {
            public string _1070287101_411461854_0_0_0 { get; set; }
        }

        public class Microfunnel_Rate_Selection
        {
        }

        public class Room_Page
        {
            public string _1070287101_411461854_0_0_0 { get; set; }
        }

        public class Rooms_List
        {
            public string _1070287101_411461854_0_0_0 { get; set; }
        }

        public class Property_Policy_Display_Details
        {
            public object legal_cases { get; set; }
        }

        public class Last_Reservation
        {
            public string time { get; set; }
            public object country { get; set; }
            public object countrycode { get; set; }
        }

        public class Breakfast_Review_Score
        {
            public decimal rating { get; set; }
            public string review_snippet { get; set; }
            public decimal review_score { get; set; }
            public decimal review_count { get; set; }
            public string review_score_word { get; set; }
            public decimal review_number { get; set; }
        }

        public class Min_Room_Distribution
        {
            public object[] children { get; set; }
            public int adults { get; set; }
        }

        public class Wifi_Review_Score
        {
            public float rating { get; set; }
        }

        public class Rooms
        {
            public _1070287101 _1070287101 { get; set; }
        }

        public class _1070287101
        {
            public Facility[] facilities { get; set; }
            public int private_bathroom_count { get; set; }
            public Children_And_Beds_Text children_and_beds_text { get; set; }
            public Private_Bathroom_Highlight private_bathroom_highlight { get; set; }
            public Photo[] photos { get; set; }
            public Bed_Configurations[] bed_configurations { get; set; }
            public Highlight[] highlights { get; set; }
            public object apartment_configuration { get; set; }
            public string description { get; set; }
        }

        public class Children_And_Beds_Text
        {
            public Children_At_The_Property[] children_at_the_property { get; set; }
            public Cribs_And_Extra_Beds[] cribs_and_extra_beds { get; set; }
            public object[] age_intervals { get; set; }
            public int allow_children { get; set; }
        }

        public class Children_At_The_Property
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Cribs_And_Extra_Beds
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Private_Bathroom_Highlight
        {
            public string text { get; set; }
            public int has_highlight { get; set; }
        }

        public class Facility
        {
            public int facilitytype_id { get; set; }
            public int alt_facilitytype_id { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string alt_facilitytype_name { get; set; }
        }

        public class Photo
        {
            public float ratio { get; set; }
            public string url_square60 { get; set; }
            public string url_original { get; set; }
            public int photo_id { get; set; }
            public string last_update_date { get; set; }
            public string url_640x200 { get; set; }
            public string url_max300 { get; set; }
        }

        public class Bed_Configurations
        {
            public Bed_Types[] bed_types { get; set; }
        }

        public class Bed_Types
        {
            public object description_localized { get; set; }
            public string description { get; set; }
            public int bed_type { get; set; }
            public string name_with_count { get; set; }
            public int count { get; set; }
            public string description_imperial { get; set; }
            public string name { get; set; }
        }

        public class Highlight
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
            public int id { get; set; }
        }

        public class Property_Highlight_Strip_Saba
        {
            public string mfeId { get; set; }
            public int serverVersion { get; set; }
            public int clientVersion { get; set; }
            public Trackedexperiment[] trackedExperiments { get; set; }
            public Root root { get; set; }
        }

        public class Root
        {
            public Props props { get; set; }
            public string type { get; set; }
        }

        public class Props
        {
            public string direction { get; set; }
            public Component component { get; set; }
        }

        public class Component
        {
            public Props1 props { get; set; }
            public string type { get; set; }
        }

        public class Props1
        {
            public Item1[] items { get; set; }
        }

        public class Item1
        {
            public Props2 props { get; set; }
            public string type { get; set; }
        }

        public class Props2
        {
            public Margin margin { get; set; }
            public Component1 component { get; set; }
            public Action[] actions { get; set; }
        }

        public class Margin
        {
            public string bottom { get; set; }
            public string top { get; set; }
            public string start { get; set; }
            public string end { get; set; }
        }

        public class Component1
        {
            public string type { get; set; }
            public Props3 props { get; set; }
        }

        public class Props3
        {
            public Item3[] items { get; set; }
            public bool fitContentWidth { get; set; }
            public string spacing { get; set; }
            public string alignment { get; set; }
            public Component2 component { get; set; }
            public Margin2 margin { get; set; }
        }

        public class Component2
        {
            public Props4 props { get; set; }
            public string type { get; set; }
        }

        public class Props4
        {
            public bool fitContentWidth { get; set; }
            public Item2[] items { get; set; }
            public string spacing { get; set; }
            public string alignment { get; set; }
        }

        public class Item2
        {
            public Props5 props { get; set; }
            public string type { get; set; }
        }

        public class Props5
        {
            public Component3 component { get; set; }
            public Margin1 margin { get; set; }
            public int lines { get; set; }
            public string font { get; set; }
            public string text { get; set; }
            public string alignment { get; set; }
            public string color { get; set; }
        }

        public class Component3
        {
            public Props6 props { get; set; }
            public string type { get; set; }
        }

        public class Props6
        {
            public string content { get; set; }
            public string size { get; set; }
            public string background { get; set; }
            public string tintColor { get; set; }
        }

        public class Margin1
        {
            public string top { get; set; }
        }

        public class Margin2
        {
            public string top { get; set; }
            public string bottom { get; set; }
            public string start { get; set; }
            public string end { get; set; }
        }

        public class Item3
        {
            public Props7 props { get; set; }
            public string type { get; set; }
        }

        public class Props7
        {
            public Component4 component { get; set; }
            public Margin3 margin { get; set; }
            public string text { get; set; }
            public string alignment { get; set; }
            public string font { get; set; }
            public int lines { get; set; }
        }

        public class Component4
        {
            public string type { get; set; }
            public Props8 props { get; set; }
        }

        public class Props8
        {
            public string size { get; set; }
            public string background { get; set; }
            public string content { get; set; }
        }

        public class Margin3
        {
            public string top { get; set; }
        }

        public class Action
        {
            public Props9 props { get; set; }
            public string type { get; set; }
        }

        public class Props9
        {
            public Experiment experiment { get; set; }
            public int goalIndex { get; set; }
            public string url { get; set; }
        }

        public class Experiment
        {
            public int variant { get; set; }
            public string id { get; set; }
            public string uviType { get; set; }
            public string name { get; set; }
            public bool shouldTrack { get; set; }
            public string uvi { get; set; }
        }

        public class Trackedexperiment
        {
            public int variant { get; set; }
            public string id { get; set; }
            public string uviType { get; set; }
            public string name { get; set; }
            public bool shouldTrack { get; set; }
            public string uvi { get; set; }
        }

        public class B_Max_Los_Data
        {
            public int default_los { get; set; }
            public int is_fullon { get; set; }
            public int extended_los { get; set; }
            public int max_allowed_los { get; set; }
            public int has_extended_los { get; set; }
            public string experiment { get; set; }
        }

        public class Facilities_Block
        {
            public Facility1[] facilities { get; set; }
            public string type { get; set; }
            public string name { get; set; }
        }

        public class Facility1
        {
            public string name { get; set; }
            public string icon { get; set; }
        }

        public class Booking_Home
        {
        }

        public class Payment_Detail
        {
            public string model { get; set; }
        }

        public class Hotel_Text
        {
        }

        public class Room_Recommendation
        {
            public decimal total_extra_bed_price { get; set; }
            public decimal adults { get; set; }
            public decimal total_extra_bed_price_in_hotel_currency { get; set; }
            public decimal babies { get; set; }
            public string block_id { get; set; }
            public decimal children { get; set; }
            public decimal number_of_extra_beds { get; set; }
        }

        public class Block
        {
            public int fit_status { get; set; }
            public object extrabed_available_amount { get; set; }
            public Fit_Occupancy fit_occupancy { get; set; }
            public int all_inclusive { get; set; }
            public int is_last_minute_deal { get; set; }
            public int roomtype_id { get; set; }
            public int is_smart_deal { get; set; }
            public int breakfast_included { get; set; }
            public object[] bh_room_highlights { get; set; }
            public int babycots_available { get; set; }
            public int room_surface_in_m2 { get; set; }
            public int room_count { get; set; }
            public int is_domestic_rate { get; set; }
            public object babycots_available_amount { get; set; }
            public int is_mobile_deal { get; set; }
            public int room_id { get; set; }
            public string block_id { get; set; }
            public int full_board { get; set; }
            public int max_children_free_age { get; set; }
            public string room_name { get; set; }
            public string max_occupancy { get; set; }
            public object is_genius_deal { get; set; }
            public object[] b_bsb_campaigns { get; set; }
            public object[] children_ages { get; set; }
            public Block_Text block_text { get; set; }
            public int must_reserve_free_parking { get; set; }
            public Product_Price_Breakdown product_price_breakdown { get; set; }
            public int nr_children { get; set; }
            public Detail_Mealplan[] detail_mealplan { get; set; }
            public float room_surface_in_feet2 { get; set; }
            public int pod_ios_migrate_policies_to_smp_fullon { get; set; }
            public int number_of_bedrooms { get; set; }
            public int number_of_bathrooms { get; set; }
            public string mealplan { get; set; }
            public string refundable_until { get; set; }
            public int half_board { get; set; }
            public int is_flash_deal { get; set; }
            public int package_id { get; set; }
            public int dinner_included { get; set; }
            public string is_block_fit { get; set; }
            public int refundable { get; set; }
            public int lunch_included { get; set; }
            public int extrabed_available { get; set; }
            public Paymentterms paymentterms { get; set; }
            public int genius_discount_percentage { get; set; }
            public int fc_deadline_till_midnight { get; set; }
            public string name_without_policy { get; set; }
            public string name { get; set; }
            public int smoking { get; set; }
            public int is_dormitory { get; set; }
            public int max_children_free { get; set; }
            public int nr_adults { get; set; }
            public int deposit_required { get; set; }
            public int can_reserve_free_parking { get; set; }
        }

        public class Fit_Occupancy
        {
            public int nr_adults { get; set; }
            public object[] children_ages { get; set; }
        }

        public class Block_Text
        {
            public Policy[] policies { get; set; }
        }

        public class Policy
        {
            public string content { get; set; }
            public string _class { get; set; }
        }

        public class Product_Price_Breakdown
        {
            public int has_long_stays_monthly_rate_price { get; set; }
            public Excluded_Amount1 excluded_amount { get; set; }
            public Included_Taxes_And_Charges_Amount1 included_taxes_and_charges_amount { get; set; }
            public int nr_stays { get; set; }
            public Gross_Amount_Per_Night1 gross_amount_per_night { get; set; }
            public All_Inclusive_Amount_Hotel_Currency1 all_inclusive_amount_hotel_currency { get; set; }
            public Gross_Amount_Hotel_Currency1 gross_amount_hotel_currency { get; set; }
            public All_Inclusive_Amount1 all_inclusive_amount { get; set; }
            public Item4[] items { get; set; }
            public Charges_Details1 charges_details { get; set; }
            public int has_long_stays_weekly_rate_price { get; set; }
            public Price_Display_Config1[] price_display_config { get; set; }
            public Net_Amount1 net_amount { get; set; }
            public object[] benefits { get; set; }
            public Gross_Amount1 gross_amount { get; set; }
        }

        public class Excluded_Amount1
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public decimal value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount1
        {
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Gross_Amount_Per_Night1
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
        }

        public class All_Inclusive_Amount_Hotel_Currency1
        {
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Gross_Amount_Hotel_Currency1
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public decimal value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class All_Inclusive_Amount1
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
        }

        public class Charges_Details1
        {
            public Amount1 amount { get; set; }
            public string translated_copy { get; set; }
            public string mode { get; set; }
        }

        public class Amount1
        {
            public string currency { get; set; }
            public decimal value { get; set; }
        }

        public class Net_Amount1
        {
            public decimal value { get; set; }
            public string amount_unrounded { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount1
        {
            public string amount_unrounded { get; set; }
            public decimal value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Item4
        {
            public string name { get; set; }
            public Item_Amount1 item_amount { get; set; }
            public Base1 _base { get; set; }
            public string details { get; set; }
            public string kind { get; set; }
            public string inclusion_type { get; set; }
        }

        public class Item_Amount1
        {
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class Base1
        {
            public int percentage { get; set; }
            public string kind { get; set; }
        }

        public class Price_Display_Config1
        {
            public int value { get; set; }
            public string key { get; set; }
        }

        public class Paymentterms
        {
            public Prepayment prepayment { get; set; }
            public Cancellation cancellation { get; set; }
        }

        public class Prepayment
        {
            public string simple_translation { get; set; }
            public string type_extended { get; set; }
            public Timeline timeline { get; set; }
            public string type { get; set; }
            public Info info { get; set; }
            public string description { get; set; }
            public string type_translation { get; set; }
            public string extended_type_translation { get; set; }
        }

        public class Timeline
        {
            public Stage[] stages { get; set; }
            public int nr_stages { get; set; }
            public string currency_code { get; set; }
            public string u_currency_code { get; set; }
            public string policygroup_instance_id { get; set; }
        }

        public class Stage
        {
            public string stage_fee_pretty { get; set; }
            public decimal current_stage { get; set; }
            public string limit_timezone { get; set; }
            public decimal fee_rounded { get; set; }
            public string amount_pretty { get; set; }
            public decimal effective_number { get; set; }
            public string u_stage_fee { get; set; }
            public string u_fee_remaining { get; set; }
            public string limit_from_date { get; set; }
            public string u_fee { get; set; }
            public string limit_until_date { get; set; }
            public string limit_until_time { get; set; }
            public decimal fee_remaining { get; set; }
            public string limit_until { get; set; }
            public decimal is_free { get; set; }
            public decimal stage_fee { get; set; }
            public string fee_pretty { get; set; }
            public string amount { get; set; }
            public decimal b_number { get; set; }
            public string u_fee_pretty { get; set; }
            public string fee_remaining_pretty { get; set; }
            public decimal fee { get; set; }
            public string text { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public string limit_from_time { get; set; }
            public string b_state { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public string limit_from_raw { get; set; }
            public decimal is_effective { get; set; }
            public string limit_until_raw { get; set; }
            public string limit_from { get; set; }
            public decimal after_checkin { get; set; }
        }

        public class Info
        {
            public string date { get; set; }
            public string timezone { get; set; }
            public string time_before_midnight { get; set; }
            public string timezone_offset { get; set; }
            public string time { get; set; }
            public int? prepayment_at_booktime { get; set; }
            public string date_before { get; set; }
            public int? is_midnight { get; set; }
            public int? refundable { get; set; }
        }

        public class Cancellation
        {
            public int non_refundable_anymore { get; set; }
            public Info1 info { get; set; }
            public string type_translation { get; set; }
            public string description { get; set; }
            public string bucket { get; set; }
            public string type { get; set; }
            public Timeline1 timeline { get; set; }
            public int guaranteed_non_refundable { get; set; }
        }

        public class Info1
        {
            public string time_before_midnight { get; set; }
            public DateTime refundable_date { get; set; }
            public DateTime refundable_date_midnight { get; set; }
            public string date_raw { get; set; }
            public int? is_midnight { get; set; }
            public string time { get; set; }
            public int? refundable { get; set; }
            public string timezone { get; set; }
            public string date { get; set; }
            public string date_before_raw { get; set; }
            public string timezone_offset { get; set; }
            public string date_before { get; set; }
        }

        public class Timeline1
        {
            public Stage1[] stages { get; set; }
            public int nr_stages { get; set; }
            public string currency_code { get; set; }
            public string u_currency_code { get; set; }
            public string policygroup_instance_id { get; set; }
        }

        public class Stage1
        {
            public string text_refundable { get; set; }
            public string b_state { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public string limit_from_raw { get; set; }
            public decimal is_effective { get; set; }
            public string limit_until_raw { get; set; }
            public string stage_translation { get; set; }
            public string limit_from { get; set; }
            public string date_until { get; set; }
            public decimal b_number { get; set; }
            public decimal fee { get; set; }
            public string u_fee_pretty { get; set; }
            public string fee_remaining_pretty { get; set; }
            public string text { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public string limit_from_time { get; set; }
            public string limit_from_date { get; set; }
            public string u_fee { get; set; }
            public string limit_until_date { get; set; }
            public decimal fee_remaining { get; set; }
            public string limit_until { get; set; }
            public string limit_until_time { get; set; }
            public decimal is_free { get; set; }
            public decimal stage_fee { get; set; }
            public string fee_pretty { get; set; }
            public string amount { get; set; }
            public decimal fee_rounded { get; set; }
            public string u_stage_fee { get; set; }
            public decimal effective_number { get; set; }
            public string u_fee_remaining { get; set; }          
            public decimal after_checkin { get; set; }
        }

        public class Detail_Mealplan
        {
            public string title { get; set; }
        }

        public class Top_Ufi_Benefits
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
        }

        public class Property_Highlight_Strip
        {
            public string name { get; set; }
            public Icon_List[] icon_list { get; set; }
        }

        public class Icon_List
        {
            public int size { get; set; }
            public string icon { get; set; }
        }

    }
}
